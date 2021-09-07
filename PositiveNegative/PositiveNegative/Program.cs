using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm palub sisestada numbrit
            //programm kontrollib numbrit
            //kui number on positiivne,sonsool kuvab "number on positiivne"
            //kui number on negatiivne,konsool kuvab "nuber on negatiivne"
            //kui sisestatud number on 0,siin konsool kuvab "nulli"
            //NB!Int32.Parse asemel kasutame Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number > 0)
            {
                Console.WriteLine("number on positiivne");
            }
            else if (number < 0)
            {
                Console.WriteLine("number on negatiivne");
            }   
            else
            {
                Console.WriteLine("null");
            }
        }
    }
}
