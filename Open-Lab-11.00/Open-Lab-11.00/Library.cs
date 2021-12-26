using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library
    {
        public int numberOfBooks = 0;
      
        public int numberOfStudents;
        public void NumberOfStudents()
        {
            numberOfStudents = StudentsList.Length;
        }


        public string[] StudentsList { get; set; } = new string[2] { "", "" };
        public string[] BooksList = new string[4] { "", "", "", "" };
        public string[] BorrowList = new string[4] { "", "", "", "" };

        public void writeall()
        {
            Console.WriteLine("amount of books: " + numberOfBooks);
            Console.WriteLine("amount of students: " + numberOfStudents);
            Console.WriteLine("Students: ");
            foreach (string s in StudentsList) { Console.WriteLine(s); }
            Console.WriteLine("Books: ");
            foreach (string s in BooksList) { Console.WriteLine(s); }
            Console.WriteLine("Borowed: ");
            foreach (string s in BorrowList) { Console.WriteLine(s); }
        }
        public string Borrowedby;
        public string Borrowedbook;
        public void borrow(string borrowedbook, string borrowedby)
        {
            
            Borrowedby = borrowedby;
            Borrowedbook = borrowedbook;
            BorrowList[numberOfBooks] = borrowedbook + " borrowed by " + borrowedby;
            BooksList [numberOfBooks] = borrowedbook;
            numberOfBooks++;
        }

    }
}
