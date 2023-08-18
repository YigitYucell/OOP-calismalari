using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    
                                            
    /*public class BaseClass                7-8.example
    {
       //abstruct public void Print
        virtual public void Print()
        {
            Console.WriteLine("Base Class summoned");
        }
    }
    public class DerivingClass1 : BaseClass
    {
        override public void Print()
        {
            Console.WriteLine("Deriving Class 1 summoned ");
        }
    }
    public class DerivingClass2 : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("Deriving Class 2 summoned");
        }
    }*/
    
    /*public class Customer                 4.exaple
    {
        public int ID;
        public string Name;
    
        public Customer(int id, string name)
        {
            this.ID = id;
            this.Name = name;
            
        }
        
        public void PrintName()
        {
            Console.WriteLine("ID - {0} and Name - {1}", this.ID,this.Name);
        }
    }*/



       /* Sınıflar
        * Class, programlarımızın her bir aşaması için çeşitli durum ve özelliklerin yer aldığı, parçalayarak bir bütün elde etmeyi amaçladığımız bir görev kontrol sistemidir.             3.example
        Projelerimizi gerçekleştirirken çeşitli özelliklerini, çözmemiz gereken problemlerini ve diğer işlemleri parçalara bölerek ilerlemek isteriz. Bu parçaları daha sonra
        birleştirerek projemizi bir bütün haline getiririz.
        public class Car            
        {
           public string brand;
           public string model;
           public string colour;
           public int year;


            public void Info()
            {
                Console.WriteLine("vehicle information {0} {1} {2} {3}", brand,model,colour,year );
            }
        }*/
    class Program
    {
        static void Main(string[] args)
        {



            /*int i = 5;                    1.example
             SampleMethod(i);  // i değişkeni etkilenmedi çıktı:5
             SampleMethod2(ref i); // i değişkeni etkilendi çıktı:100           
             Console.WriteLine(i);                                                  

            int[] _Numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ParameterMethod(_Numbers);

            Console.ReadKey();*/
            ////////////////////////////////////////////////////////////////////////

            /*Process(12, 6);                   2.example
            Process(3, 4, 5);
            Process(12, 18, 10, 5);

            Console.ReadKey();*/
            ////////////////////////////////////////////////////////////////////////

            /* Car car = new Car();      3.exaple
             car.brand = "Volkswagen";
             car.model = "Golf";
             car.colour = "Black";
             car.year = 2023;
             car.Info(); 

             Console.ReadKey();*/
            ///////////////////////////////////////////////////////////////////////






            /*Metot Parametreleri                                    1.exaple
             Temel veri tipleri olan int, double, float ve struct gibi veri türleri value type; herhangi bir sınıf türü ise (string, object) reference type’tır.
             Referans parametresi ile yapılan değişikliklerde sonradan yapılan işlemler sonucu etkilemez.
             Params metotların değişken sayıda parametre almasına imkan veren bir anahtar kelimedir.
             Parametre sayısı belli olmayan metot tanımlamak için params özelliği kullanılabilir.*/


            /*
            public static void SampleMethod(int a)
            {
                a = 100;
            }

            public static void SampleMethod2(ref int b)
            {
                b = 100;
            }
            public static void ParameterMethod(params int[] Numbers)  // parametre sayısı belli değil ise params kullanılır
            {
                foreach(int i in Numbers)
                {
                    Console.WriteLine(i);
                }

            }*/

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*Overloading(Aşırı Yükleme)                        2.example
             Overloading, uygulamalarımız içerisinde oluşturmuş olduğumuz metot yapılarının yeniden yazılmasına, esneklik kazanmasına ve daha fazla işlevsel bir yapıya 
            geçmesine imkan sağlayarak aynı isimde birden fazla parametreleri farklı metotlar oluşmasına imkan sağlayan yapıdır.*/

            /* static void Process(int num1, int num2)
             {
                 int result = num1 / num2;
                 Console.WriteLine("result = " + result);
             }
             static void Process(int num1, int num2, int num3)
             {
                 int result = num1 * num2 * num3;
                 Console.WriteLine("result= " + result);
             }
             static void Process(int num1, int num2, int num3, int num4)
             {
                 int result = num1 + num2 + num3 + num4;
                 Console.WriteLine("result = " + result);
             }*/

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            /* Yapıcı Metotlar                               4.example
             Constructor, nesne yönelimli programlama kavramı içerisinde bulunan sınıf yapılarının nesne olarak tanımlanmasında alt yapıyı hazırlayan, kurucu rolü üstlenen, sınıf
             ismi ile aynı isime sahip olan, geriye değer döndürmeyen fonksiyon türleridir.*/


            /* Customer c1 = new Customer(1,"Yigit");
             c1.PrintName();
             Console.ReadKey();*/

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /* Statik Üyeler 
             İçinde buluduğu sınıftan nesne oluşturulmadan veya hiç bir nesneye referans olmadan kullanılabilen üyeler static olarak nitelendirilir. Metotlar ve alanlar
             statik olarak tanımlanabilir.
            Transactions.Addition(2,3);                        5.example
            Console.ReadKey();       */
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            /*-Kapsülleme                                       6.example
             * Kapsülleme, sınıf yapımız içerisinde yer alan private erişim seviyesindeki değişkenlerin ve metot yapılarının dışarıdan güvenli bir şekilde erişilmesini
            sağlamak amacıyla ya da güvenli bir şekilde muhafaza etmek için kullanılan önemli bir nesne yönelimli programlama özelliğidir.

            Student s1 = new Student();
            s1.setName("Yigit");
            s1.getName();
            Console.ReadKey();*/
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*Çok Biçimlilik                                    7 - 8.example
             * Bir temel sınıfın özellik ve metotlarını, temel sınıftan türetilen bir sınıfa aktardığımızda temel sınıfa ait metotları türemiş sınıf içerisinde de kullanabiliriz.
             * Temel sınıfa ait metotları türemiş sınıfta farklı biçimlerde tanımlayarak kullanmak için override ve virtual niteleyicilerini kullanmak gereklidir.

            BaseClass bc1 = new DerivingClass1();   // Temel sınıf ile oluşturduğumuz nesne türetilmiş sınıf metodunu çağırdı
            bc1.Print();

            BaseClass bc2 = new DerivingClass2();
            bc2.Print();

            Console.ReadKey();*/
            /*
             * Soyut sınıflar kendisinden türeyen sınıflardır.Bu sınıflardan nesne oluşturamayız.
            Soyut sınıfı extend eden sınıf soyut sınıfın tüm soyut metotlarını override etmek zorundadır.
            Extends ederek farklı sınıflarda kullanabiliriz.Her extends ettiğimiz sınıfta, soyut sınıfların özellikleri kullanılarak farklı sonuçlar üretilir.*/
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }

    }
}

