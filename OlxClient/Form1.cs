using System;
using System.Windows.Forms;

namespace OlxClient
{
    public partial class Form1 : Form
    {
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

        private void ProcessServerResponse(string serverResponse)
        {
            throw new NotImplementedException();
        }

        private string SendToServer(string v)
        {
            throw new NotImplementedException();
        }
    }
}
