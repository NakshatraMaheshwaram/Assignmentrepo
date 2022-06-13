using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibraryManagement1
{
    internal class Issue
    {
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\AssignmentRepo\IssueFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            streamWriterObj.WriteLine("ISSUE DETAILS");
            Console.WriteLine("Enter the Book Name");
            streamWriterObj.Write("\nBook Name : ");
            streamWriterObj.WriteLine(Console.ReadLine());

            Console.WriteLine("Enter Issue Date");
            streamWriterObj.Write("Date of Issue : ");
            streamWriterObj.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine("Enter Name of Borrower");
            streamWriterObj.Write("Issued By : ");
            streamWriterObj.WriteLine(Console.ReadLine());
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed in Issue");

        }
    }
}

