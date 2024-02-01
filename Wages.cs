using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Wages:Employee
    {
        private double rate;
        private double hours;

        public Wages(string id, string name, string address, string phone, long sin, string dob, string dept, double rate,double hours)
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
        public double Rate {  
            get { return rate; } 
            set { rate = value; }
        }
        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public override double GetPay()
        {
            double overTimeRate =this.Rate*1.5;
            double OvetimeHours=this.hours-40;
            double pay = (this.Rate * 40) + (overTimeRate * OvetimeHours);
            return pay;

        }
        public override string ToString()
        {
            return $"Employee information\nEmployee category:Wages\nname:{Name}\nid:{Id}\naddress:{Address}\nphone:{Phone}\nsin{Sin}\ndob{Dob}\ndept:{Dept}";
        }
    }
}
