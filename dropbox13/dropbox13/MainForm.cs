namespace dropbox13
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            DataEntryForm entryForm = new DataEntryForm();
            entryForm.ShowDialog();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DisplayForm displayform = new DisplayForm();
            displayform.ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.ShowDialog();
        }
    }
}