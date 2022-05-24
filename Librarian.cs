using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement1
{
    internal class Librarian
    {
        public static void InsertBook()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\AssignmentRepo\BooksFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            Console.WriteLine("How many books do you want to enter :");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("Enter the Book ID");
                streamWriterObj.Write("\nBook ID : ");
                streamWriterObj.WriteLine(Console.ReadLine());

                Console.WriteLine("Enter the Book Name");
                streamWriterObj.Write("\nBook Name : ");
                streamWriterObj.WriteLine(Console.ReadLine());

                Console.WriteLine("Enter Auther Name");
                streamWriterObj.Write("Auther Name : ");
                streamWriterObj.WriteLine(Console.ReadLine());

                Console.WriteLine("Enter Prize of Book");
                streamWriterObj.Write("Book Prize : ");
                streamWriterObj.WriteLine(Console.ReadLine());
            }
        }
        public static void DeleteBook()
        {

        }
        public static void Borrower()
        {

        }

        public void Login()
        {
            string username = Console.ReadLine();
            Console.WriteLine("Enter the username " + username);
            string password = Console.ReadLine();
            Console.WriteLine("Enter the password " + password);
        }
        public void UserVerification()
        {
            Console.WriteLine("Enter the password: ");
            string Password = Console.ReadLine();
            if (Password == "123")
            {
                bool close = true;
                while (close)
                {
                    Console.WriteLine("\nMenu\n " + "1.Add book\n " +
                        "2.Delete book\n " + "3.Borrow book\n " + "4.Close\n ");
                    Console.WriteLine("chosse your option: ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    if (option == 1)
                    {
                        InsertBook();
                    }
                    else if (option == 2)
                    {
                        DeleteBook();
                    }
                    else if (option == 3)
                    {
                        Borrower();
                    }

                    else if (option == 4)
                    {
                        Console.WriteLine("close");
                        close = false;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("invalid option..\n ");
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid password\nCheck your password ");
            }
            Console.ReadLine();
        }
    }
}

