using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement1
{
    internal class Inventory
    {
        public void WriteFile()
        {
            FileStream fileStreamObj = new FileStream(@"C:\Users\hp\Documents\AssignmentRepo\InventoryFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter streamWriterObj = new StreamWriter(fileStreamObj);
            streamWriterObj.WriteLine("INVENTORY DETAILS");
            string dt = DateTime.Now.ToShortDateString();
            string returndate = "5/26/2022";

            int perdayCost = 10;
            DateTime dt1 = Convert.ToDateTime(returndate);
            DateTime dt2 = Convert.ToDateTime(dt);

            var d = dt1 - dt2;
            Console.WriteLine(d.Days * perdayCost);
            streamWriterObj.WriteLine("Fees : " + d.Days * perdayCost);
            streamWriterObj.Close();
            fileStreamObj.Close();
            Console.WriteLine("File write operation completed in Inventory");

        }
    }
}
    
}
