using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework01.Salary;

namespace Homework01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetSalary_Click(object sender, EventArgs e)
        {
            int baseSalay;
            int benefit;
            Empolyee 吳漢武 = new Empolyee();

            if(BaseSalaryTextBox.Text == "")
            {
                BaseSalaryTextBox.Text = 吳漢武.BaseSalary.ToString();                               
            }

            baseSalay = int.Parse(BaseSalaryTextBox.Text);
            吳漢武.BaseSalary = baseSalay;

            benefit = int.Parse(BenefitTextBox.Text);
            吳漢武.Benefit = benefit;

            MessageBox.Show("吳漢武的薪水:\n"+ 吳漢武.Salary.ToString()); 

        }
    }
}
