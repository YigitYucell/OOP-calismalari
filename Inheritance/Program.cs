using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        /*Kalıtım
          Inheritance (kalıtım), bir türetilen sınıfın özellik ve davranışlarını, bir alt sınıfın miras alarak sanki kendi üyeleriymiş gibi kullanmasıdır.*/
        public class Customer
        {
            public string Name;
            public string LastName;
            public string City;
        
            public void PrintFullName()
            {
                Console.WriteLine(Name+ " "+LastName);

            }

        }
        public class LocalCustomer : Customer
        {
            public int MonthlyPayment;

            public void PrintMonthlyPayment()
            {
                Console.WriteLine("Monthly payment= " + MonthlyPayment);
            }

        }

        public class ForeignCustomer : Customer
        {
            public int YearlyPayment;
            public void PrintYearlyPayment()
            {
                Console.WriteLine("Yearly payment= " + YearlyPayment);
            }
        }



        static void Main(string[] args)
        {
            LocalCustomer lcs = new LocalCustomer();
            lcs.Name = "Yigit";
            lcs.LastName = "Yucel";
            lcs.City = "İstanbul";
            lcs.MonthlyPayment = 10000;
            lcs.PrintFullName();
            lcs.PrintMonthlyPayment();

            Console.WriteLine("*************************************");

            ForeignCustomer fcs = new ForeignCustomer();
            fcs.Name = "Tom";
            fcs.LastName = "Sawyer";
            fcs.City = "londra";
            fcs.YearlyPayment = 20000;
            fcs.PrintFullName();
            fcs.PrintYearlyPayment();












            Console.ReadKey();
        }
    }
}
