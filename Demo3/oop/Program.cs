using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Demo3.Class1;
using static Demo3.student;

namespace Demo3
{
    class Program
    {

       /* public abstract class Shape
        {
            public abstract void Draw();
        }

        public class Square : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a square.");
            }
        }

        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a circle.");
            }
        }*/


        static void Main(string[] args)
        {
            /* Square d = new Square();
             d.Length = Convert.ToInt32(Console.ReadLine());
             d.Width = Convert.ToInt32(Console.ReadLine());          //KAPSÜLLEME
             Console.WriteLine("Length:" + d.Length + "Width:" + d.Width);
             Console.WriteLine(d.area());
             Console.ReadKey();*/
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*Square square = new Square();
            Circle circle = new Circle();

            square.Draw();          //Soyutlama
            circle.Draw();

            Console.ReadKey();*/
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /*Person person = new Person
            {
                FirstName = "Mert",
                LastName = "Kara"
            };
            person.DisplayFullName();

            Student student = new Student       //Kalıtım
            {
                FirstName = "Burak",
                LastName = "Yaman",
                StudentID = 12345
            };
            student.DisplayFullName();
            student.Study();

            Console.ReadKey();*/
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            MusicalInstrument instrument1 = new Guitar();
            MusicalInstrument instrument2 = new Piano();    // Çok biçimlilik

            instrument1.Play(); 
            instrument2.Play(); 

            Console.ReadKey();



        }
    }
}
