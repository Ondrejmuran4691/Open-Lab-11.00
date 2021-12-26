using System;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Library SchoolLibrary = new Library();
            Book Hobit = new Book("Hobit", "J.R.Tolkien","scifi", 420,1900);
            Book Bedari= new Book("Bedari","Victor Hugo", "novel",426,1952);
            Book Tulak = new Book("Tulak", "Klara Jarunkova", "novel",655,1995);
            Book Jano = new Book("Jano","Frano Kral", "novel",955,1985);

            SchoolLibrary.StudentsList[0] = "John";
            SchoolLibrary.StudentsList[1] = "Poul";
            SchoolLibrary.NumberOfStudents();
            SchoolLibrary.borrow("Jano", "John");
            SchoolLibrary.borrow("Tulak", "John");
            SchoolLibrary.borrow("Bedari", "Poul");
            SchoolLibrary.borrow("Hobit", "Poul");
            SchoolLibrary.writeall();




        }
    }
}
