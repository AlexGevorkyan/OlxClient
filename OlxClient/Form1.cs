using OlxClient.Models;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Windows.Forms;

namespace OlxClient
{
    public partial class Form1 : Form
    {
        TcpClient? client;
        NetworkStream? ns;

        public string CurrentUserRole { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string serverResponse = SendToServer($"Login: {username} Password:{password}");

            ProcessServerResponse(serverResponse);
        }

        private void btPSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPName.Text) || string.IsNullOrEmpty(tbPPrice.Text)
                || string.IsNullOrEmpty(tbPUnit.Text) || string.IsNullOrEmpty(tbPStatus.Text))
            {
                MessageBox.Show("Enter all information about your product");
                return;
            }

            if (!Int32.TryParse(tbPPrice.Text, out int price) || price <= 0)
            {
                MessageBox.Show("Price must be more than 0");
                return;
            }

            try
            {
                client = new TcpClient();
                client.Connect(tbAddress.Text.Trim(), Convert.ToInt32(tbPort.Text.Trim()));
                ns = client.GetStream();

                Product product = new()
                {
                    //Id = 
                    ProductName = tbPName.Text.Trim(),
                    Price = price,
                    Description = rtbPDescription.Text.Trim(),
                    Unit = tbPUnit.Text.Trim(),
                    Status = tbPStatus.Text.Trim()
                    //SellerId = 
                };

                Models.Message message = new()
                {
                    Name = "Product",
                    Data = JsonSerializer.Serialize(product)
                };

                SendProduct(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to connect: {ex.Message}");
                Disconnect();
            }

        }

        private void SendProduct(Models.Message message)
        {
            if (ns == null)
                return;

            byte[] data = JsonSerializer.SerializeToUtf8Bytes(message);
            byte[] length = BitConverter.GetBytes(data.Length);

            ns.Write(length);
            ns.Write(data);
            ns.Flush();
        }

        private void Disconnect()
        {
            try { ns?.Close(); } catch { }
            try { client?.Close(); } catch { }
            ns = null;
            client = null;
        }

        private void ProcessServerResponse(string serverResponse)
        {
            throw new NotImplementedException();
        }

        private string SendToServer(string request)
        {
            if (ns == null)
                throw new InvalidOperationException("Not connected to server.");

            byte[] data = System.Text.Encoding.UTF8.GetBytes(request);

            byte[] length = BitConverter.GetBytes(data.Length);
            ns.Write(length, 0, length.Length);

            ns.Write(data, 0, data.Length);
            ns.Flush();

            byte[] responseLengthBytes = new byte[sizeof(int)];

            ReadExactly(ns, responseLengthBytes);

            int responseLength = BitConverter.ToInt32(responseLengthBytes, 0);

            if (responseLength <= 0 || responseLength > 1024 * 1024)
                throw new InvalidOperationException("Invalid server response length.");

            byte[] responseData = new byte[responseLength];

            ReadExactly(ns, responseData);

            return System.Text.Encoding.UTF8.GetString(responseData);
        }

        private void ReadExactly(NetworkStream stream, byte[] buffer)
        {
            int offset = 0;

            while (offset < buffer.Length)
            {
                int read = stream.Read(
                    buffer,
                    offset,
                    buffer.Length - offset);

                if (read == 0)
                    throw new Exception("Server disconnected.");

                offset += read;
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show(
                    "Enter login and password",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show(
                    "Enter a valid email address.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (phone.Length < 10)
            {
                MessageBox.Show(
                    "Enter a valid phone number.",
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                client = new TcpClient();

                client.Connect(
                    tbAddress.Text.Trim(),
                    Convert.ToInt32(tbPort.Text.Trim()));

                ns = client.GetStream();

                string request = 
                    $"Register: {username} " + 
                    $"Password:{password} " + 
                    $"Phone:{phone} " + 
                    $"Email:{email}";

                string response = SendToServer(request);

                MessageBox.Show(
                    response,
                    "Registration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Disconnect();
            }
            catch (FormatException)
            {
                MessageBox.Show("Port must be a number.");
                Disconnect();
            }
            catch (SocketException ex)
            {
                MessageBox.Show($"Unable to connect to server: {ex.Message}");
                Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Registration error: {ex.Message}");
                Disconnect();
            }
        }
    }
}