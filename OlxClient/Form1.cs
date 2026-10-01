using System;
using System.Windows.Forms;
using OlxClient.Models;

namespace OlxClient
{
    public partial class Form1 : Form
    {
        public string CurrentUserRole { get; private set; }
        public Form1()
        {
            InitializeComponent();

            btPSend.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

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

            Product product = new Product()
            {
                //Id = 
                ProductName = tbPName.Text.Trim(),
                Price = price,
                Description = rtbPDescription.Text.Trim(),
                Unit = tbPUnit.Text.Trim(),
                Status = tbPStatus.Text.Trim()
                //SellerId = 
            };



        }

        private void ProcessServerResponse(string response)
        {
            var parts = response.Split(',');

            if (parts[0] == "Success")
            {
                CurrentUserRole = parts[1];
                MessageBox.Show($"Login successful. Role: {CurrentUserRole}");

                txtUsername.Visible = false;
                txtPassword.Visible = false;
                btnLogin.Visible = false;
                btnRegister.Visible = false;
                lbLogin.Visible = false;
                lbPassword.Visible = false;

                tabControl1.SelectedIndex = 1;
    
                if (CurrentUserRole == "Admin")
                {
                    btPSend.Visible = true;
                    //btnDelete.Visible = true;
                }
                else if (CurrentUserRole == "User")
                {
                    btPSend.Visible = true;
                    //btnDelete.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Login failed");
            }
        }

        private string SendToServer(string message)
        {
            if (message.StartsWith("Register"))
            {
                return "Success,Registered";
            }

            if (message.Contains("admin"))
            {
                return "Success,Admin";
            }

            return "Success,User";
        }

        // registration doesn't work because the server is not implemented yet, but the client side is ready to send the registration request to the server
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }
            string serverResponse = SendToServer($"Register: {username} Password:{password}");

            if (serverResponse.StartsWith("Success"))
            {
                MessageBox.Show("Registration successful. You can now login");

                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Registration failed");
            }
        }
    }
}
