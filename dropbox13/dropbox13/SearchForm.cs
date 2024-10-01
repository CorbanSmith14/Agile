using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox13
{
    public partial class SearchForm : Form
    {
        List<Student> students = new List<Student>();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("student.txt"))
            {
                using StreamReader sr = new StreamReader("student.txt");
                string studentId;
                while ((studentId = sr.ReadLine()) != null)
                {
                    string name = sr.ReadLine();
                    int score = int.Parse(sr.ReadLine());
                    Student s = new Student(studentId, name, score); students.Add(s);
                }
            }
            else
            {
                MessageBox.Show("Missing student.txt file.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (students.Count > 0 &&
                !string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                Student student = students.Find
                    (s => s.StudentId == searchTextBox.Text);
                if (student != null)
                {
                    idLabel.Text = student.StudentId;
                    nameLabel.Text = student.Name;
                    gradeLabel.Text = student.GetLetterGrade().ToString();
                    printButton.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No students found.");
                    idLabel.Text = string.Empty;
                    nameLabel.Text = string.Empty;
                    gradeLabel.Text = string.Empty;
                    printButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No students or Missing seach string.");
                printButton.Enabled = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();

        }
    }
}
