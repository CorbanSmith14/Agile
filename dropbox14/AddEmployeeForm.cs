using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox14
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using StreamWriter sw = File.AppendText("employee.txt");
            if (!(String.IsNullOrWhiteSpace(idTextBox.Text) ||
                String.IsNullOrWhiteSpace(nameTextBox.Text) ||
                string.IsNullOrWhiteSpace(payrateTextBox.Text)))
            {
                if (decimal.TryParse(payrateTextBox.Text, out decimal payRate) && payRate >= 0)
                {
                    Employee employee = new Employee
                        (idTextBox.Text, nameTextBox.Text, payRate);
                    sw.WriteLine(employee);
                    clearButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("Pay rate must be a number.");
                }
            }
            else
            {
                MessageBox.Show("All fields are required.");
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            idTextBox.Clear();
            nameTextBox.Clear();
            payrateTextBox.Clear();
            idTextBox.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
