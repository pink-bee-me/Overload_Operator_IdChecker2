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
            Console.WriteLine("Enter First Employee ID#:");
            int id_1 = Convert.ToInt32(Console.ReadLine());
          

            Console.WriteLine("Enter Second Employee ID#:");
            int id_2 = Convert.ToInt32(Console.ReadLine());




            CompareEmployeeIDs CompareIDs = new CompareEmployeeIDs(id_1, id_2);

            
            Console.WriteLine("Are the Employee ID's Equal:");
            Console.WriteLine(id_1 == id_2);
            Console.ReadLine();









        }
    }
}
