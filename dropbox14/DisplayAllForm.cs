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

namespace dropbox14
{
    public partial class DisplayAllForm : Form
    {
        public DisplayAllForm()
        {
            InitializeComponent();
        }

        private void DisplayAllForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("employee.txt"))
            {
                using StreamReader sr =
                    new StreamReader("employee.txt");
                string employeeid;
                while ((employeeid = sr.ReadLine()) != null)
                {
                    string name = sr.ReadLine();
                    decimal payrate = decimal.Parse(sr.ReadLine());
                    decimal hoursworked =
                        decimal.Parse(sr.ReadLine());
                    Employee employee = new Employee(employeeid, name, payrate, hoursworked);
                    string str = $"Employee ID: {employee.EmployeeId}" +
                       $"Name: {employee.Name}" +
                       $"Pay Amount: {employee.PayAmount():C}";
                    EmployeeListBox.Items.Add(str);
                }
            }
            else
            {
                MessageBox.Show("Missing employee.txt File.");
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            { printDocument1.Print(); }
        }
        private void printDocument1_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Employee Payroll",
                new Font("Courier New", 24, FontStyle.Bold),
                Brushes.Black, 250, 100);
            e.Graphics.DrawString(DateTime.Now.ToString(),
                new Font("Courier New", 12, FontStyle.Italic),
                Brushes.Black, 300, 150);
            int x = 100, y = 200;
            foreach (var row in EmployeeListBox.Items)
            {
                e.Graphics.DrawString(row.ToString(),
                    new Font("Courier New", 12, FontStyle.Regular),
                    Brushes.Black, x, y);
                y += 16;
            }
        }
    }
}
