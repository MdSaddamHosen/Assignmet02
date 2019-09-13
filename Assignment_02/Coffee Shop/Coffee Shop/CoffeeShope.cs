using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class CoffeeShope : Form
    {
        public CoffeeShope()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string Customer_Name = customerNameTextBox.Text;
            string Contract_No = contractNoTextBox.Text;
            string address = addressTextBox.Text;
            string Order = orderComboBox.Text;
            if (orderComboBox.Text== " ")
            {
                MessageBox.Show("Select an Item");

            }
            else
            {
                MessageBox.Show("succesful added");
            }
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int price = 0;
            if (orderComboBox.Text == "Black-120")
            {
                price = 120 * quantity;
            }
            else if (orderComboBox.Text == "Cold-100")
            {
                price = 100 * quantity;
            }
            else if (orderComboBox.Text == "Hot-90")
            {
                price = 90 * quantity;
            }
            else if (orderComboBox.Text == "Regular-80")
            {
                price = 80 * quantity;
            }
            int total_cost = price;
            displayItemRichTextBox.AppendText( "Customer Name: " +  Customer_Name +  "\n contract No: " +  Contract_No  + "\n Address: " +  address +  "\n order_item :"  + Order +  "\n Quantity :" + quantity+"\n  total cost: " +total_cost);
        }
    }
}
