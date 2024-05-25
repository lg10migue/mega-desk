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
    public partial class ViewAllQuotes : Form
    {

        public ViewAllQuotes()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            // Check quotes.
            if (Program.quotes.Count != 0)
            {
                var viewModelList = Program.quotes.Select(q => new
                {
                    Price = q._quote,
                    CustomerName = q._customerName,
                    ProductionTime = q._productionTime,
                    QuoteDate = q._quoteDate,
                    DeskWidth = q._desk._width,
                    DeskDepth = q._desk._depth,
                    DrawerCount = q._desk._drawerCount,
                    Material = q._desk._material.ToString(),
                    Size = q._desk._size
                }).ToList();


                quotesView.DataSource = viewModelList;

                // Customize Column Names.
                quotesView.Columns["CustomerName"].HeaderText = "Customer Name";
                quotesView.Columns["ProductionTime"].HeaderText = "Production Time";
                quotesView.Columns["QuoteDate"].HeaderText = "Quote Date";
                quotesView.Columns["DeskWidth"].HeaderText = "Desk Width";
                quotesView.Columns["DeskDepth"].HeaderText = "Desk Depth";
                quotesView.Columns["DrawerCount"].HeaderText = "Drawer Count";
                quotesView.Columns["Size"].HeaderText = "Desk Size";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Tag = this;
            menu.Show(this);
            this.Hide();
        }
    }
}
