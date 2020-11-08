using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operator_IdChecker2
{
    class CompareEmployeeIDs

    {
        public int ID_1 { get; set; }
        public int ID_2 { get; set; }
    
        public CompareEmployeeIDs()
        {

        }
        public CompareEmployeeIDs(int id_1, int id_2)
        {
            ID_1 = id_1;
            ID_2 = id_2;
        }

        public static bool operator ==(CompareEmployeeIDs id_1, CompareEmployeeIDs id_2)
        {
            bool duplicate = false;

            if (id_1 == id_2)
            {
                duplicate = true;
            }
            return duplicate;
        }

        public static bool operator !=(CompareEmployeeIDs id_1, CompareEmployeeIDs id_2)
        {
            bool notDuplicate = false;

            if (id_1 != id_2)
            {
                notDuplicate = true;

            }
            return notDuplicate;
        }

    }
}
