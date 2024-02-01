using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class PartTime:Employee
    {
        private double rate;
        private double hours;

        public PartTime() { }
        public PartTime( string id, string name, string address, string phone, long sin, string dob, string dept, double rate, double hours)
        {
            Id = id;
            Name = name;
            Address = address;
            Phone = phone;
            Sin = sin;
            Dob = dob;
            Dept = dept;
            Rate = rate;
            Hours = hours;
        }

        public double Rate 
        { get { return rate; }
          set { rate = value; }
        }
        public double Hours
        {
            get { return hours; }
            set { hours= value; }
        }

        public override double GetPay()
        {
            return this.Rate * 40;

        }
    }
}
