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
            if (ns == null || client == null)
            {
                MessageBox.Show("Not connected to server");
                return;
            }

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
            catch { }

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

        private string SendToServer(string v)
        {
            throw new NotImplementedException();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient();
                client.Connect(tbAddress.Text.Trim(), Convert.ToInt32(tbPort.Text.Trim()));
                ns = client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to connect: {ex.Message}");
                Disconnect();
            }
        }
    }
}
