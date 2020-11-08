using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator_IdChecker2
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareEmployeeIDs CompareIDs_1 = new CompareEmployeeIDs();
            CompareEmployeeIDs CompareIDs_2 = new CompareEmployeeIDs();

            Console.WriteLine("Enter First Employee ID#:");
            CompareIDs_1.ID = Convert.ToInt32(Console.ReadLine());
          

            Console.WriteLine("Enter Second Employee ID#:");
            CompareIDs_2.ID = Convert.ToInt32(Console.ReadLine());




    


            Console.WriteLine(" Are the Employee IDs Equal:");
            Console.WriteLine(CompareIDs_1.ID == CompareIDs_2.ID);
            Console.WriteLine("\n Are the Employee IDs Not Equal:");
            Console.WriteLine(CompareIDs_1.ID != CompareIDs_2.ID);
            Console.WriteLine("\n If Employee IDs are EQUAL this means they are DUPLICATE ENTRIES \n If Employees are NOT EQUAL, this means there is no detection of duplicate entry");
            Console.ReadLine();









        }
    }
}
