using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Salaried:Employee
    {
        private double salary;

        public Salaried() { }
        public  Salaried(string id, string name, string address, string phone, long sin, string dob, string dept,double salary) 
        { 
            Id = id;
            Name = name;    
            Address = address;
            Phone = phone;
            Sin = sin;
            Dob = dob;
            Dept = dept;
            Salary = salary;
        }

        public double Salary
        {  
            get { return salary; } 
            set {  salary = value; }
        }

        public override double GetPay()
        {
            return this.Salary;
        }

        public override string ToString()
        {
            return $"Employee information\nEmployee category:Salaried\nname:{Name}\nid:{Id}\naddress:{Address}\nphone:{Phone}\nsin{Sin}\ndob{Dob}\ndept:{Dept}";
        }
    }
}
