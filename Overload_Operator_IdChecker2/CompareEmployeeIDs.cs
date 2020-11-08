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
        public int ID { get; set; }
     
    
        public CompareEmployeeIDs()
        {

        }

        public static bool operator == ( CompareEmployeeIDs CompareIDs_1, CompareEmployeeIDs CompareIDs_2)
        {
            bool duplicate = false;

            if ( CompareIDs_1.ID == CompareIDs_2.ID)
            {
                duplicate = true;
            }
            return duplicate;
        }

        public static bool operator !=(CompareEmployeeIDs CompareIDs_1, CompareEmployeeIDs CompareIDs_2)
        {
            bool notDuplicate = false;

            if (CompareIDs_1.ID != CompareIDs_2.ID)
            {
                notDuplicate = true;

            }
            return notDuplicate;
        }

    }
}
