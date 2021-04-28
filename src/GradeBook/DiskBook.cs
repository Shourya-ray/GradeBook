using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class DiskBook : BookBase
    {
        public DiskBook(String name) : base(name)
        { 
        }
        public override event GardeAddedDelegate GradeAdded;

        public override void AddGrades(double grade)
        {
            using (TextWriter writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                //witer.clos(); if we do not use using
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
                else { throw new ArgumentException("Invalid Grade"); }

            }
        }

        public override Stats GetStats()
        {
            
            var result = new Stats();

            using (TextReader reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = double.Parse(line);
                    result.add(number);
                    line = reader.ReadLine();
                
                }

            }
            return result;
        }
    }
}
