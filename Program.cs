namespace lab2
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            List<object> EmployeInfo = new List<object>();
            char[] salaried = { '0', '1', '2', '3', '4' };
            char[] waged = { '5', '6', '7' };
            char[] partTime = { '8', '9' };

            void LoadEmployee(string filepath)
            {
                using StreamReader read = new StreamReader(filepath);
                string line;
                int count = 0;
                while ((line = read.ReadLine() )!= null)
                {
                    Employee object1 = new Employee();
                    count++;

                    string[] IndivsualInfo = line.Split(":");


                    if (Array.Exists(salaried, element => element == IndivsualInfo[0][0]))
                    {

                        string id = IndivsualInfo[0];
                        string name = IndivsualInfo[1];
                        string address = IndivsualInfo[2];
                        string phone = IndivsualInfo[3];
                        long sin = long.Parse(IndivsualInfo[4]);
                        string dob = IndivsualInfo[5];
                        string dept = IndivsualInfo[6];
                        double salary = double.Parse(IndivsualInfo[7]);
                        object1 = new Salaried(id, name, address, phone, sin, dob, dept, salary);

                    }

                    else if (Array.Exists(waged, element => element == IndivsualInfo[0][0]))
                    {

                        string id = IndivsualInfo[0];
                        string name = IndivsualInfo[1];
                        string address = IndivsualInfo[2];
                        string phone = IndivsualInfo[3];
                        long sin = long.Parse(IndivsualInfo[4]);
                        string dob = IndivsualInfo[5];
                        string dept = IndivsualInfo[6];
                        double rate = double.Parse(IndivsualInfo[7]);
                        double hours = double.Parse(IndivsualInfo[8]);
                        object1 = new Wages(id, name, address, phone, sin, dob, dept, rate, hours);

                    }


                    else
                    {
                        string id = IndivsualInfo[0];
                        string name = IndivsualInfo[1];
                        string address = IndivsualInfo[2];
                        string phone = IndivsualInfo[3];
                        long sin = long.Parse(IndivsualInfo[4]);
                        string dob = IndivsualInfo[5];
                        string dept = IndivsualInfo[6];
                        double rate = double.Parse(IndivsualInfo[7]);
                        double hours = double.Parse(IndivsualInfo[8]);
                        object1 = new PartTime(id, name, address, phone, sin, dob, dept, rate, hours);

                    }

                    EmployeInfo.Add(object1);


                }








            }
             double GetAveragePay()
            {
                double sum = 0.0;
                int count = 0;

                foreach (Employee object1 in EmployeInfo)
                {

                    sum += object1.GetPay();
                    count++;

                }
                return sum / count;
            }


             string GetHighestPay()
            {
                double highest = 0.0;
                string name = "";

                foreach (Employee object1 in EmployeInfo)
                {

                    if (object1.GetPay() > highest)
                    {
                        highest = object1.GetPay();
                        name = object1.Name;
                    }


                }
                return $"{name} gets the highest pay which is {highest}";
            }



            string GetLowestPay()
            {
                double lowest = 10000000;
                string name = "";

                foreach (Employee object1 in EmployeInfo)
                {

                    if (object1.GetPay() < lowest)
                    {
                        lowest = object1.GetPay();
                        name = object1.Name;
                    }


                }
                return $"{name} gets the lowest pay which is {lowest}";
            }


            string GetPercentage()

            {
                double Salariedno = 0;
                double Wagedno = 0;
                double PartTimeno = 0;
                double total = 0;

                foreach (Employee object1 in EmployeInfo)
                {


                    if (object1.Id[0] == '0' || object1.Id[0] == '1' || object1.Id[0] == '2' || object1.Id[0] == '3' || object1.Id[0] == '4')
                    {
                        Salariedno += 1;
                        total += 1;
                    }

                    else if (object1.Id[0] == '5' || object1.Id[0] == '6' || object1.Id[0] == '7')
                    {
                        Wagedno += 1;
                        total += 1;
                    }
                    else
                    {
                        PartTimeno += 1;
                        total += 1;
                    }


                }

                double SalariedPercentage = (Salariedno / total) * 100;
                double WagedPercentage = (Wagedno / total) * 100;
                double PartTimePercentage = (PartTimeno / total) * 100;

                return $"{SalariedPercentage}% of people fall into salaried category\n{WagedPercentage}% of people fall into Waged category\n{PartTimePercentage}% of people fall into Part time category";
            }

            LoadEmployee("C:\\Users\\Arya\\Desktop\\oop2\\lab2\\lab2\\res\\employees.txt");
            Console.WriteLine($"The average pay is: {GetAveragePay()}");
            Console.WriteLine(GetHighestPay());
            Console.WriteLine(GetLowestPay());
            Console.WriteLine(GetPercentage());
            



        }
    }
}
