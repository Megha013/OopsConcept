using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Date
    {
        //declare data members
        private int day, year;
        private string month;
        //method for assign the value to the data member
        public void AcceptDate(int dd,string mm,int yy)
        {
            day = dd; //assignment done from right to left
            month = mm;
            year = yy;
        }
        //return the date to main method
        public string DisplayDate()
        {
            return $"Date is : {day}/{month}/{year}";
        }
    }
}
