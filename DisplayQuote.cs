using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace megaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(string date, string cost, string customer, string rushTime)
        {
            InitializeComponent();
            quoteDate.Text = date;
            quotePrice.Text = cost;
            customerName.Text = customer;
            rush.Text = rushTime;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show(this);
            Hide();
        }
    }
}
