using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static megaDesk.Desk;

namespace megaDesk
{
    public partial class SearchQuotes : Form
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

        public SearchQuotes()
        {
            InitializeComponent();
            materialSearch.DataSource = Enum.GetValues(typeof(Desk.Material));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Tag = this;
            menu.Show(this);
            this.Hide();
        }

        private void materialSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desk.Material searchMat = (Desk.Material)materialSearch.SelectedValue;
            results.Items.Clear();

            foreach (DeskQuote quote in quotes)
            {
                // Create listview item for each quote with a matching material
                if (quote._desk._material == searchMat)
                {
                    ListViewItem item = new(quote._customerName);
                    item.SubItems.Add(quote._desk._material.ToString());
                    item.SubItems.Add($"{quote._desk._width} x {quote._desk._depth}");
                    item.SubItems.Add(quote._quoteDate.ToString());
                    item.SubItems.Add(quote._quote.ToString());
                    results.Items.Add(item);
                }
            }
        }

    }
}
