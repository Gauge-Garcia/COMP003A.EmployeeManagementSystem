using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.EmployeeManagementSystem
{
    /// <summary>
    /// This is the Employee Class. This is where we build the different outputs of our soon to employee input by the user
    /// </summary>
    internal class Employee
    {
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        /// <summary>
        /// Employee ID value
        /// </summary>
        public string EmployeeId
        {
            get { return _employeeId; }
        }

        /// <summary>
        /// Employee firstname. This method sets a string value for the first name and ensures that it is not null or blank.
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First Name is required");
                }
            }
        }

        /// <summary>
        /// Employee LastName. This method sets a string value for the last name and ensures that it is not null or blank.
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    _lastName = value;
                    throw new ArgumentException("Last Name is required");
                }
            }
        }
        /// <summary>
        /// Employee MiddleName. This method sets a string value for the middle name and ensures that it is not null.
        /// </summary>
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == null)
                {
                    _middleName = " ";
                }
                _middleName = value;
            }
        }
        /// <summary>
        /// Employee Salary. This method sets a double value for the salay and ensures that it is not negative. The double is so that the salary can be larger because our employee makin BANK!!!
        /// </summary>
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (_salary < 0)
                {
                    throw new ArgumentException("You cannot have a negative salary");
                }
                _salary = value;
            }
        }

        /// <summary>
        /// This Public emplyee constructor sets each function equal to a variable in order to ensure that our checks in the employee 
        /// </summary>
        /// <param name="employeeId"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="salary"></param>
        public Employee(string employeeId, string firstName, string middleName, string lastName, double salary)
        {
            _employeeId = employeeId;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Salary = salary;
        }


        /// <summary>
        /// The PrintFullName method prints the employees full name.
        /// </summary>
        public void PrintFullName()
        {
            if (string.IsNullOrEmpty(MiddleName))
            {
                Console.WriteLine($"Employee Name: {FirstName} {LastName}");
            }
            else
            {
                Console.WriteLine($"Employee Name: {FirstName} {MiddleName} {LastName}");

            }
        }
        /// <summary>
        /// The DisplayEmployeeInfo function displays the Employees ID, Name, and Salary.
        /// </summary>
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            PrintFullName();
            Console.WriteLine($"Salary: ${Salary} \n");
        }
    }
}
