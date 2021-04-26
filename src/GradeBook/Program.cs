using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Book Br= new Book("Scotts Grade Book");
            //Br.AddGrades(24);
            //Br.AddGrades(55);
            //Br.AddGrades(17);
            //Br.AddGrades(87);
            //Br.AddGrades(100);
            var input = "";
            Double Grade;
            while (true)
            {
                Console.WriteLine("Enter Grades or q to quit");
                input = Console.ReadLine();
                if (input == "q")
                { break; }
                try
                {
                    Grade = Convert.ToDouble(input);
                    Br.AddGrades(Grade);
                }
                catch (ArgumentException ex)
                { Console.WriteLine(ex.Message); }
                catch (FormatException ex)
                { Console.WriteLine(ex.Message); }

            }

            var Result = Br.GetStats();
            //List<double> Grades =new <double>();
            Console.WriteLine("Hello World!");
            Console.WriteLine($"The Avg of Grades is {Result.avg} ");

            Console.WriteLine($"The Highest of Grades is {Result.high} ");

            Console.WriteLine($"The lowest of Grades is {Result.low} ");
            Console.WriteLine($"The Letter of Grades is {Result.Letter} ");
        }
    }
}
