// Author: Gauge Garcia
// Course: COMP-003A
// Faculty: Johnathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

namespace COMP003A.EmployeeManagementSystem
{
    internal class Employee
    {
        private string _employeeId;
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private double _salary;

        public string EmployeeId
        {
            get { return _employeeId; }
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("First Name is required");
                }
                _firstName = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Last Name is required");
                }
                _lastName = value;
            }
        }
        public string MiddleName
        {
            get { return _middleName; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Middle Name cannot be null, but can be empty");
                }
                _middleName = value;
            }
        }
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

        // constructor
        public Employee(string employeeId, string firstName, string middleName, string lastName, double salary)
        {
            _employeeId = employeeId;
            _firstName = firstName;
            _middleName = middleName;
            _lastName = lastName;
            _salary = salary;
        }



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
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {EmployeeId}");
            PrintFullName();
            Console.WriteLine($"Salary: ${Salary} \n");
        }
    }

    abstract class Department
    {
        public string DepartmentName { get; set; }

        public abstract string GetDepartmentDetails();
        public void DisplayDepartmentInfo()
        {
            Console.WriteLine($"This is the {DepartmentName}");
            Console.WriteLine($"{GetDepartmentDetails()} \n ");
        }
    }
    class HRDepartment : Department, IDepartmentOperations
    {
        public override string GetDepartmentDetails()
        {
            return $"The {DepartmentName} handles employee relations and recruitment.";            
        }
        public void Operate()
        {
            Console.WriteLine($"The {DepartmentName} is currently addressing employee altercations and ensuring employee saftey.");
        }
    }
    class ITDepartment : Department, IDepartmentOperations
    {
        public override string GetDepartmentDetails()
        {
            return $"The {DepartmentName} manages technical resources and infastructure.";
        }
        public void Operate()
        {
            Console.WriteLine($"The {DepartmentName} is taking care of internet and software issues across the company.");
        }
    }
    interface IDepartmentOperations
    {
        void Operate();
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            int _salary;
            
            Console.Write("Enter Employee ID:");
            string _employeeId = Console.ReadLine();
            Console.Write("Enter First Name:");
            string _firstName = Console.ReadLine();
            Console.Write("Enter Middle Name (Press enter to skip):");
            string _middleName = Console.ReadLine();
            Console.Write("Enter Last Name:");
            string _lastName = Console.ReadLine();
            Console.Write("Enter Salary:");
            _salary =  int.Parse((Console.ReadLine()));
            Console.WriteLine("Employee Created Successfully!");

            Employee Employee1 = new Employee(_employeeId, _firstName, _middleName, _lastName, _salary);
            Employee1.DisplayEmployeeInfo();
            

            Department _ItDepartment = new ITDepartment { DepartmentName = "IT Department" };
            Department _HrDepartment = new HRDepartment { DepartmentName = "HR Department"};

            _ItDepartment.DisplayDepartmentInfo();

            _HrDepartment.DisplayDepartmentInfo();

        }  
    }
}
