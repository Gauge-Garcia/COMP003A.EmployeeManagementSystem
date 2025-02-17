using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// This is the ITDepartment Class. This is where we display details and operatons of the department using the Operate and Details Mehtods!
    /// </summary>
    class ITDepartment : Department, IDepartmentOperations
    {
        public override string GetDepartmentDetails()
        {
            return $"The {DepartmentName} manages technical resources and infastructure.";
        }
        public override void Operate()
        {
            Console.WriteLine($"The {DepartmentName} is taking care of internet and software issues across the company.\n");
        }
    }
}
