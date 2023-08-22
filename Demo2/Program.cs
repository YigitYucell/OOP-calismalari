using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    /* class Car
     {
     public string brand;
     public string model;                     // Sınıf
     public string colour;
     public int year;
     }*/
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////  
    /*class Personal
        {
            public string name, surname;
        }
        class AcademicPersonal : Personal   // personal sınıfı ile kalıtım yoluyla academic personel sınıfına erişildi.   //  Kalıtım
        {
            public string mail, degree;
        }*/

    /* class Additon
     {
         public static void numberAdditon(int num1, int num2)
         {                                                                   //Statik
             Console.WriteLine("Result= " + (num1 + num2));
         }
     }*/

    /*class number
     {
         private int a = 10;

         public int A
         {
             get
             {                               //Kapsülleme
                 return a;
             }
             set
             {
                 a = value;
             }
         }
     }*/


    class Program
    {



        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*  Car c = new Car();  // Car sınıfından nesne oluşturuldu ve değişkenler kullanıldı.
              c.brand = "Audi";
              c.model = "A5";                                                                 // Sınıflar
              c.colour = "Black";
              c.year = 2023;*/

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
          
            /*AcademicPersonal p = new AcademicPersonal();
              p.name = "Yigit";
              p.surname = "Yucel";
              p.degree = "Stajyer";
              p.mail = "yigit@gmail.com";                   //  Kalıtım
              Console.ReadKey();*/

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /* Additon.numberAdditon(5, 10);                 //Statik
             Console.ReadKey();      */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*
            number num = new number();          
            num.A = 15;                     // Kapsülleme ile private olan değişkene erişildi. Çıktı kullanıcının verdiği son değer oldu.
            Console.WriteLine(num.A);
            Console.ReadLine();*/
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /*Console.WriteLine(Multiply(2, 5));
            Console.WriteLine(Multiply(2, 5, 3));       //Aşırı Yükleme
            Console.ReadLine();*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }
        //////////////////////////////////////////////////////////////////////////   
        /* static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Multiply(int num1, int num2, int num3)      // Aşırı Yükleme
        {
            return num1 * num2 * num3;
        }*/
        //////////////////////////////////////////////////////////////////////////
        


    }
}
