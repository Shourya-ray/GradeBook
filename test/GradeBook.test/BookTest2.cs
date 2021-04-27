using System;
using Xunit;
using GradeBook;

namespace GradeBook.test
{
    public delegate string WriteLogDelegate(String log);
    public class BookTest2
    {
      int  count=0;
        //delegate
        [Fact]
        public void WritelogdelegateTest()
        { //arrange

            WriteLogDelegate log;
            log = Logmessage;
            log += Logmessage;
            var result = log("Delegate test");
            //assert 
            Assert.Equal(2, count);
        
            //Assert.Equal("Book 2", Book2.name);
            //Assert.NotSame(Book1, Book2);

        }
        public string Logmessage(String message)
        {
            count++;
            return message;
        }
        [Fact]
        public void StringareRef()
        { //arrange
            String Name = "Shourya";
            String n1;
            n1=SetStringName(Name);


            //assert 
            Assert.Equal("Shourya", Name);
            Assert.Equal("SHOURYA", n1);
           
            //Assert.Equal("Book 2", Book2.name);
            //Assert.NotSame(Book1, Book2);

        }

        public String SetStringName(string Parameter)
        {
            
            return Parameter.ToUpper();
        }

        [Fact]
        public void PassByRef()
        { //arrange
            var Book1 = GetBook("Book 1");
            GetBookSetNameRef("NewBook", ref Book1);




            //assert 
            Assert.Equal("NewBook", Book1.name);
            //Assert.Equal("Book 2", Book2.name);
            //Assert.NotSame(Book1, Book2);

        }

        private void GetBookSetNameRef(string v, ref Book book)
        {
            book = new Book(v);
            
        }
        [Fact]
        public void PassByvalue()
        { //arrange
            var Book1 = GetBook("Book 1");
            GetBookSetName("NewBook", Book1);
        

        

            //assert 
            Assert.Equal("Book 1", Book1.name);
            //Assert.Equal("Book 2", Book2.name);
            //Assert.NotSame(Book1, Book2);

        }

        private void GetBookSetName(string v, Book book)
        {
            book = new Book(v);
         
        }

        [Fact]
        public void ChangeName()
        { //arrange
            var Book1 = GetBook("Book 1");
            SetName("NewBook", Book1);
            //Book.AddGrades(24);
            //Book.AddGrades(55);
            //Book.AddGrades(17);
            //Book.AddGrades(87);
            //Book.AddGrades(100);


            //var result = Book.GetStats();

            //assert 
            Assert.Equal("NewBook", Book1.name);
            //Assert.Equal("Book 2", Book2.name);
            //Assert.NotSame(Book1, Book2);

        }

        private void SetName(string v, Book book)
        {
            book.name = v;
        }

        [Fact]
        public void GetDiffrentobj()
        { //arrange
            var Book1 = GetBook("Book 1");
            var Book2 = GetBook("Book 2");
            //Book.AddGrades(24);
            //Book.AddGrades(55);
            //Book.AddGrades(17);
            //Book.AddGrades(87);
            //Book.AddGrades(100);


            //var result = Book.GetStats();

            //assert 
            Assert.Equal("Book 1",Book1.name);
            Assert.Equal("Book 2", Book2.name);
            Assert.NotSame(Book1, Book2);
        }


        [Fact]
        public void GetSameobj()
        { //arrange
            var Book1 = GetBook("Book 1");
            var Book2 = Book1;
            //Book.AddGrades(24);
            //Book.AddGrades(55);
            //Book.AddGrades(17);
            //Book.AddGrades(87);
            //Book.AddGrades(100);


            //var result = Book.GetStats();

            //assert 
            Assert.Same(Book1, Book2);
            Assert.True(Object.ReferenceEquals(Book1, Book2));
            
        }

        //act
        public Book GetBook(string a)
        {
            return new Book(a);
        }


    }
}
