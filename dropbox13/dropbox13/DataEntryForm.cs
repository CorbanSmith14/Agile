using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox13
{
    public partial class DataEntryForm : Form
    {
        public DataEntryForm()
        {
            InitializeComponent();
        }

        private void DataEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            scoreTextBox.Clear();
            idTextBox.Focus();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using StreamWriter sw = File.AppendText("student.txt");
            if(!(string.IsNullOrWhiteSpace(idTextBox.Text)||
                string.IsNullOrWhiteSpace(nameTextBox.Text)||
                string.IsNullOrWhiteSpace(scoreTextBox.Text)))
            {
                if(int.TryParse(idTextBox.Text, out int score)
                    &&score>=0 && score <=100)
                {
                    Student student = new Student
                        (idTextBox.Text, nameTextBox.Text, score);
                    sw.WriteLine(student);
                    clearButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Score must be an interger[0,100]");
                }
            }
            else
            {
                MessageBox.Show("All Fields are required.");
            }
        }
    }
}
