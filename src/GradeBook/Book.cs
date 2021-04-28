using System;
using System.Collections.Generic;



namespace GradeBook
{ 

			public  delegate void GardeAddedDelegate(object sender,EventArgs args);
    public abstract class BookBase : NamedObject, IBook
	{
        protected BookBase(string name): base(name)
        {
           
        }

        public abstract event GardeAddedDelegate GradeAdded;

        public abstract void AddGrades(double grade);

		public abstract Stats GetStats();
       
    }
	public interface IBook
	{
		void AddGrades(double grade);
		Stats GetStats();
		string Name { get; set; }
		event GardeAddedDelegate GradeAdded;
	}
    public class Book : BookBase 
	{
				public Book( string name) :base(name)
				{
					grade = new List<double>();
					Name = name;
				}
			
				public override void AddGrades(double Grades)
				{
						if (Grades <= 100 && Grades >= 0)
						{
						grade.Add(Grades);
						if (GradeAdded !=null)
						{ GradeAdded(this,new EventArgs()); }
						}
						else
						{ throw new ArgumentException("Invalid Grade"); }
				   }

				public override event GardeAddedDelegate GradeAdded;
				public override Stats GetStats()
				{ var result = new Stats();
					  
						foreach (var number in grade)
						{

						result.add(number);

						}
						
						

						return result;

				} private List<double> grade;
				}
    }