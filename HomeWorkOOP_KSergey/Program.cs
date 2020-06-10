using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOOP_KSergey
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHello("Дно", 36);

            var person1 = new Person();
            person1.ReadCreateDirectoryF();
            

           

            Console.ReadKey();
        }

        public static void PrintHello(string name, int age)
        {
            
            //Console.WriteLine($"Привет, {name}. Вам {age} лет");
            //Console.ReadLine();

        }
        

        
    }
}
