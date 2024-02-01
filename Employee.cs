using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{

    public class Employee
    {
        private string id;
        private string name;
        private string address;
        private string phone;
        private long sin;
        private string dob;
        private string dept;

        public Employee() { }   
        public Employee(string id, string name, string address, string phone, long sin, string dob, string dept)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.sin = sin;
            this.dob = dob;
            this.dept = dept;
        }

        public string Id { 
            get { return id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        public string Address
        {
            get { return address; }
            set { this.address = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { this.phone = value; }
        }
        public long Sin
        {
            get { return sin; }
            set { this.sin = value; }
        }
        public string Dob
        {
            get { return dob; }
            set { this.dob = value; }

        }
        public string Dept
        {
            get { return dept; }
            set { this.dept = value; }
        }
        public virtual String ToString()
        {
            return $"Employee information\nname:{this.name}\nid:{this.id}\naddress:{this.address}\nphone:{this.phone}\nsin{this.sin}\ndob{this.dob}\ndept:{this.dept}";
        }
        public virtual double GetPay()
        {
            return 0.0;
        }
    }
}
