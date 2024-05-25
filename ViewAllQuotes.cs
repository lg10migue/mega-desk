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

        // TODO: this should come from the JSON, and probably not live in this file
        // This exists only for testing search and will be deleted
        DeskQuote[] quotes =
        {
            new DeskQuote("Levi", new Desk(40, 40, 2, Desk.Material.Rosewood), "3 Days", DateTime.Today),
            new DeskQuote("Otherguy", new Desk(40, 40, 2, Desk.Material.Pine), "3 Days", DateTime.Today),
            new DeskQuote("Ron Paul", new Desk(40, 40, 2, Desk.Material.Rosewood), "3 Days", DateTime.Today),
            new DeskQuote("John F", new Desk(40, 40, 2, Desk.Material.Oak), "3 Days", DateTime.Today),
            new DeskQuote("Kennedy Johnson", new Desk(40, 40, 2, Desk.Material.Veneer), "3 Days", DateTime.Today)
        };

        public ViewAllQuotes()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            var viewModelList = quotes.Select(q => new
            {
                Quote = q._quote,
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
