using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalaryUI : Form
    {
        private Salary aSalary;

        public EmployeeSalaryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            
            
            aSalary = new Salary();
            aSalary.Basic = Convert.ToDouble(basicEntryTextBox.Text);
            aSalary.Medical = Convert.ToDouble(medicalEntryTextBox.Text);
            aSalary.Conveyance = Convert.ToDouble(conveyanceEntryTextBox.Text);

            
            Employee aEmployee= new Employee();
            aEmployee.Id = idTextBox.Text;
            aEmployee.Name = nameTextBox.Text;
            aEmployee.Email = emailTextBox.Text;
            aEmployee.ASalary = aSalary;

            MessageBox.Show(@" Account has been created.");

        }

        private void incrementButton_Click(object sender, EventArgs e)
        {
            double incrementPersent = Convert.ToDouble(incrementEntryTextBox.Text);
            aSalary.SetInceiment(incrementPersent);
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            basicShowTextBox.Text = aSalary.Basic.ToString();
            medicalShowTextBox.Text = aSalary.GetMedical().ToString();
            conveyanceShowTextBox.Text = aSalary.GetConveyance().ToString();
            totalShowTextBox.Text = aSalary.GetTotal().ToString();
            noOfIncrementShowTextBox.Text = aSalary.Increment.ToString();

        }
    }
}
