using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01.Salary
{
    class Empolyee
    {
        private int salary;
        private int baseSalary;
        private int benefit;
         
        public int Salary
        {
            get
            {
                return this.salary = this.baseSalary + this.benefit ;
                
            }
            
        }
        public int BaseSalary
        {
            get 
            {
                return this.baseSalary = 22000;
            }
            set
            {
                    if (value <= 22000)
                    {
                        this.baseSalary = 22000;
                    }
                    else if (value >= 60000)
                    {
                        this.baseSalary = 60000;
                    }
                    else
                    {
                        this.baseSalary = value;
                    }
            }
        }
        public int Benefit
        {
            get 
            {
                return this.benefit; 
            }
            set 
            {
                if(value >= 10000)
                {
                    this.benefit = 10000;
                }
                else
                {
                    this.benefit = value;
                }
            }
        }
        

    }
}
