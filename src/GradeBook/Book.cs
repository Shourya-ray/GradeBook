using System;
using System.Collections.Generic;



namespace GradeBook
	{ 
			public class Book
			{
				public Book()
				{
					grade = new List<double>();
				}
				List<double> grade;
							public void AddGrades(double Grades)
						{
						grade.Add(Grades);
						}

				
			}
	}