using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Student
    {
        private int id;
        private string name;
        private double math, eng, hindi,total,per;
        public Student()
        {
            
        }
        public Student(int sid,string sname,double m,double e, double h)
        {
            id = sid;
            name = sname;
            math = m;
            eng = e;
            hindi = h;
        }
        public void TotalMarks()
        {
            total = math + eng + hindi;
        }
        public void CalculatePercentage()
        {
            per = total / 3;
        }
        public string Print()
        {
            return $"Id={id}, Name={name}, Percentage={per}";
        }
    }
}
