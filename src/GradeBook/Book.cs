using System;
using System.Collections.Generic;



namespace GradeBook
	{ 
			public class Book
			{
				public Book( string name)
				{
					grade = new List<double>();
					this.name = name;
				}
			
				public void AddGrades(double Grades)
				{
				grade.Add(Grades);
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


			return result;

		}
				private List<double> grade;
				private string name;

        
    }
	}