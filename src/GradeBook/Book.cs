using System;
using System.Collections.Generic;



namespace GradeBook
	{ 
			public class Book
			{
				public Book( string Name)
				{
					grade = new List<double>();
					 name =  Name ;
				}
			
				public void AddGrades(double Grades)
				{
						if (Grades <= 100 && Grades >= 0)
						{
                grade.Add(Grades);
						}
						else
						{ throw new ArgumentException("Invalid Grade"); }
        }
				public Stats GetStats()
				{ var result = new Stats();
					  result.avg = 0.0;
   					  result.high = Double.MinValue;
			          result.low = Double.MaxValue;
						foreach (var number in grade)
						{
							result.high = Math.Max(result.high, number);
							result.low = Math.Min(result.low, number);
							result.avg = result.avg + number;

						}
							result.avg /=  grade.Count;
						switch (result.avg)
						{
						case var data when data > 90.0:
							result.Letter = 'a';
							break;
						case var data when data > 80.0:
							result.Letter = 'b';
							break;
						case var data when data > 70.0:
							result.Letter = 'c';
							break;
						case var data when data > 60.0:
							result.Letter = 'd';
							break;
						default:
							result.Letter = 'f';
							break;

			}

			return result;

		}
				private List<double> grade;
				public string name;

        
    }
	}