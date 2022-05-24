using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] NoOfBooks = new string[3];
            string[] NoOfUsers = new string[3];



            Books books = new Books();
            User user = new User();
            Inventory inventory = new Inventory();
            Issue issue = new Issue();



            //for (int i = 0; i < NoOfBooks.Length; i++)
            //{
            //    books.WriteFile();
            //}
            //for (int i = 0;i < NoOfUsers.Length;i++)
            //{
            //    user.WriteFile();
            //}


            inventory.WriteFile();
            //issue.WriteFile();



            Console.ReadLine();
        }
    }
}
