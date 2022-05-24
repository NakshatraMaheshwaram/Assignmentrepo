using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement1
{
    internal class Books
    {
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\AssignmentRepo\BooksFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            streamWriterObj.WriteLine("BOOKS DETAILS");

            Console.WriteLine("Enter the Book ID");
            streamWriterObj.Write("\nBook ID : ");
            streamWriterObj.WriteLine(Console.ReadLine());

            Console.WriteLine("Enter the Book Name");
            streamWriterObj.Write("\nBook Name : ");
            streamWriterObj.WriteLine(Console.ReadLine());

            Console.WriteLine("Enter Author Name");
            streamWriterObj.Write("Author Name : ");
            streamWriterObj.WriteLine(Console.ReadLine());

            Console.WriteLine("Enter Prize of Book");
            streamWriterObj.Write("Book Prize : ");
            streamWriterObj.WriteLine(Console.ReadLine());
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine();

        }
    }
}