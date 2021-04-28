using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Stats 
    {

        public double high;
        public double low;
        
        public double count;
        public double Sum;
        public char Letter
        {
            get             
            {
                switch (avg)
                {
                    case var data when data > 90.0:

                        return 'A';
                       
                    case var data when data > 80.0:

                        return 'B';
                    case var data when data > 70.0:

                        return 'c';
                    case var data when data > 60.0:

                        return 'D';
                    default:
                        return 'F';

                }

            }
        
        }
        public double avg
        {
            get 
            {
                return Sum / count;
            }
        }
        
        public Stats()
        {
            Sum = 0.0;
            count = 0.0;
            //avg = 0.0;
            high = Double.MinValue;
            low = Double.MaxValue;
        }
        public void add(double number)
        {
            Sum += number;
            count += 1;

            low = Math.Min(low, number);
            high = Math.Max(high, number);

        }
    
       




}
}
