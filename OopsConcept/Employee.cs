using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Employee
    {
        private int id;
        private string name;
        private double basic, hra, da, pf, gross;

        public Employee()
        {

        }
        public Employee(int eid,string ename,double b)
        {
            id = eid;
            name = ename;
            basic = b;
        }
        public void CalculateSalary()
        {
            hra = basic * 0.40;
            da = basic * 0.20;
            pf = basic * 0.12;
            gross = (basic + hra + da) - pf;
        }
        public string Print()
        {
            return $"Id={id}, Name={name}, Gross Salary={gross}";
        }
    }
}
