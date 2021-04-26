using System;
using Xunit;
using GradeBook;

namespace GradeBook.test
{
    public class BookTest
    {
        [Fact]
        public void Test1()
        { //arrange
            var Book = new Book("");
            Book.AddGrades(24);
            Book.AddGrades(55);
            Book.AddGrades(17);
            Book.AddGrades(87);
            Book.AddGrades(100);

            //act
            var result=Book.GetStats();

            //assert 
            Assert.Equal(56.6,result.avg);
             Assert.Equal(100,result.high);
             Assert.Equal(17,result.low);
            Assert.Equal('f', result.Letter);
        }
    }
}
