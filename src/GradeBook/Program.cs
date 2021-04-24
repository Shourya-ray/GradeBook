using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

            Book Br= new Book("Scotts Grade Book");
            Br.AddGrades(24);
            Br.AddGrades(55);
            Br.AddGrades(17);
            Br.AddGrades(87);
            Br.AddGrades(100);
           
            var Result = Br.GetStats();
            //List<double> Grades =new <double>();
            Console.WriteLine("Hello World!");
            Console.WriteLine($"The Avg of Grades is {Result.avg} ");

            Console.WriteLine($"The Highest of Grades is {Result.high} ");

            Console.WriteLine($"The lowest of Grades is {Result.low} ");
        }
    }
}
