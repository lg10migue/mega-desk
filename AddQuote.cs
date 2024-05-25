using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace megaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            material.DataSource = Enum.GetValues(typeof(Desk.Material));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Tag = this;
            menu.Show(this);
            this.Hide();
        }

        private void deskWidth_Validating(object sender, CancelEventArgs e)
        {
            double num = 0;
            TextBox textBox = (TextBox)sender;

            // check min and max
            if (!double.TryParse(textBox.Text, out num) || !(num >= Desk.MIN_DESK_W && num <= Desk.MAX_DESK_W))
            {
                MessageBox.Show($"Please enter a number between {Desk.MIN_DESK_W} and {Desk.MAX_DESK_W}", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Text = "";
            }
        }

        private void drawerCount_TextChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void deskDepth_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            try
            {
                if (!string.IsNullOrWhiteSpace(textBox.Text))
                {
                    if (!double.TryParse(textBox.Text, out _))
                    {
                        MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox.Text = "";
                    }
                }
            }
            catch
            {
                Console.WriteLine("Validation error");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Desk.Material selectedMat = (Desk.Material)material.SelectedValue;
            Desk desk = new Desk(Convert.ToInt32(deskWidth.Text), Convert.ToInt32(deskDepth.Text), Convert.ToInt32(drawerCount.Text), selectedMat);
            DeskQuote quote = new DeskQuote(customerName.Text, desk, rush.SelectedItem.ToString(), DateTime.Now);

            Program.quotes.Add(quote);

            string updatedJson = JsonConvert.SerializeObject(Program.quotes, Formatting.Indented);

            File.WriteAllText(Program.jsonFilePath, updatedJson);

            DisplayQuote screen = new DisplayQuote(quote._quoteDate.ToString(), quote._quote.ToString(), quote._customerName, quote._productionTime.ToString());
            screen.Tag = this;
            screen.Show(this);
            Hide();
        }
    }
}
