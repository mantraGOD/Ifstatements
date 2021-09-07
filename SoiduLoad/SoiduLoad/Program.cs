using System;

namespace SoiduLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kasutajat,kas ta on piisavalt vana,et juhiload saada

            Console.WriteLine("Sisesta oma sünniaasta:");

            int YearOfBirth = Int32.Parse(Console.ReadLine());
            int Age = 2021 - YearOfBirth;

            if (Age >= 18)
            {
                Console.WriteLine("Oled piisavalt vana,et juhiload saada");
            }
            
            {
                Console.WriteLine("Liiga noor,et juhiload saada");
            }
            else
            {
                Console.WrileLine("Oled 18,nüüd saad juhiload")
            }






        }
    }
}
