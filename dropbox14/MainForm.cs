namespace dropbox14
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm();
            addEmployeeForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hoursButton_Click(object sender, EventArgs e)
        {
            AddHoursForm addHoursForm = new AddHoursForm();
            addHoursForm.ShowDialog();
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DisplayAllForm displayAllForm = new DisplayAllForm();
            displayAllForm.ShowDialog();
        }
    }
}