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
    public partial class AddHoursForm : Form
    {
        List<Employee> employees = new List<Employee>();
        public AddHoursForm()
        {
            InitializeComponent();
        }
        private void AddHoursForm_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            if (File.Exists("employee.txt"))
            {
                using StreamReader sr =
                    new StreamReader("employee.txt");
                string employeeId;
                while ((employeeId = sr.ReadLine()) != null)
                {
                    Employee employee = new Employee(employeeId,
                        sr.ReadLine(),
                        decimal.Parse(sr.ReadLine()),
                        decimal.Parse(sr.ReadLine()));
                    employees.Add(employee);
                }
                if (employees.Count > 0)
                {
                    idLabel.Text = employees[0].EmployeeId;
                    nameLabel.Text = employees[0].Name;
                }
                else
                {
                    MessageBox.Show("No employees in the file.");
                    nextButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Missing employee.txt");
                nextButton.Enabled = false;
            }
        }
        int count = 1;
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(hoursTextBox.Text,
                out decimal hours)
                && hours >= 0)
            {
                employees[count - 1].Hoursworked = hours;
                if (count < employees.Count)
                {
                    idLabel.Text = employees[count].EmployeeId;
                    nameLabel.Text = employees[count].Name;
                    count++;
                }
                else
                {
                    MessageBox.Show("no more records.");
                    nextButton.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Hours worked must be a number.");
            }
            clearButton.PerformClick();
        }

        private void closeandsaveButton_Click(object sender, EventArgs e)
        {
            using StreamWriter sw = File.CreateText("employee.txt");
            foreach (Employee employee in employees)
            {
                sw.WriteLine(employee);
            }
            Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            hoursTextBox.Clear();
            hoursTextBox.Focus();
        }
    }
}
