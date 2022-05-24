using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement1
{
    internal class User
    {
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\AssignmentRepo\UserFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            streamWriterObj.WriteLine("USER DETAILS");
            Console.WriteLine("Enter the User Id");
            streamWriterObj.Write("\nUser Id : ");
            streamWriterObj.WriteLine(Console.ReadLine());

            Console.WriteLine("Enter the Name");
            streamWriterObj.Write("User Name : ");
            streamWriterObj.WriteLine(Console.ReadLine());

            Console.WriteLine("Enter Email Address");
            streamWriterObj.Write("User Email : ");
            streamWriterObj.WriteLine(Console.ReadLine());

            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine();

        }
    }
}
}
