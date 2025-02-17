using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// This is the abstract Department class. This class is essentially the blue print for the different department classes coming soon!
    /// </summary>
    abstract class Department
    {
        public string DepartmentName { get; set; }

        /// <summary>
        /// GetDepartmentDetails() intializes the display to come later
        /// </summary>
        /// <returns>
        /// GetDepartmentDetails() Returns the Department Name and Description
        /// </returns>
        public abstract string GetDepartmentDetails();

        /// <summary>
        /// Operate() initializes operation display
        /// </summary>
        /// <returns> 
        /// Operate() returns the departments current operation
        /// </returns>
        public abstract void Operate();

        /// <summary>
        /// DisplayDepartmentInfo() displays the Department Info.
        /// </summary>
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"This is the {DepartmentName}");
            Console.WriteLine($"{GetDepartmentDetails()}");
        }
    }
}
