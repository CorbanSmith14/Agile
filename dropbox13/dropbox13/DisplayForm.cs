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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("student.txt"))
            {
                using StreamReader sr = new StreamReader("student.txt");
                string studentId;
                while ((studentId = sr.ReadLine()) != null)
                {
                    string name = sr.ReadLine();
                    int score = int.Parse(sr.ReadLine());
                    Student student = new Student(studentId, name, score);
                    string str = $"Student Id: {student.StudentId}" +
                        $"Name:{student.Name}" +
                        $"Grade: {student.GetLetterGrade()}";
                    studentsListBox.Items.Add(str);
                }
            }
            else
            {
                MessageBox.Show("Missing student.txt file.");
            }
        }

        private void closeeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
