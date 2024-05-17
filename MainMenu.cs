namespace megaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes();
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotes = new ViewAllQuotes();
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            Hide();
        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Tag = this;
            addQuoteForm.Show(this);
            Hide();
        }
    }
}
