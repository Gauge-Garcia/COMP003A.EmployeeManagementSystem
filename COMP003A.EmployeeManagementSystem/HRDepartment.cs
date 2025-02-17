using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// This is the HRDepartment Class. This is where we display details and operatons of the department using the Operate and Details Mehtods!
    /// </summary>
    class HRDepartment : Department, IDepartmentOperations
    {
        public override string GetDepartmentDetails()
        {
            return $"The {DepartmentName} handles employee relations and recruitment.";
        }
        public override void Operate()
        {
            Console.WriteLine($"The {DepartmentName} is currently addressing employee altercations and ensuring employee saftey.\n");
        }
    }
}
