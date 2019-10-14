using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorAppPractice3
{
    public partial class SalaryCalculatorUi : Form
    {
        public SalaryCalculatorUi()
        {
            InitializeComponent();
        }
        Salary aSalary = new Salary();
        private void ShowMeSalaryButton_Click(object sender, EventArgs e)
        {
            aSalary.employeeName = employeeNameTextBox.Text;
            aSalary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            double rent = Convert.ToDouble(homeRentTextBox.Text);
            double medical = Convert.ToDouble(medicalAllowanceTextBox.Text);
            double totalSalary = aSalary.GetTotalSalary(rent, medical);
            MessageBox.Show(aSalary.employeeName + " , your salary is : " + totalSalary);
        }
    }
}
