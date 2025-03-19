using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_basics.March_19_2025.Properties_Demo
{
    class Employee
    {
        //Declaring Private Fields
        private int _employeeID;
        private string _eName;

        //Declaring public properties
        public int EmployeeID
        {
            set { _employeeID = value; }
            get { return _employeeID; }
        }

        public string EName
        {
            get { return _eName; }
            set { _eName = value; }
        }



    }
}
