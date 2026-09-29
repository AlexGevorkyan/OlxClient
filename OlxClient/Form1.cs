using OlxClient.Models;

namespace OlxClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btPSend_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbPName.Text) || string.IsNullOrEmpty(tbPPrice.Text) 
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








    }
}
