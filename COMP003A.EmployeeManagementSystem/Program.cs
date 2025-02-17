// Author: Gauge Garcia
// Course: COMP-003A
// Faculty: Johnathan Cruz
// Purpose: Employee management system demonstrating OOP principles in C#

namespace COMP003A.EmployeeManagementSystem
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int salary;
            try
            {
                Console.Write("Enter Employee ID:");
                string employeeId = Console.ReadLine();
                Console.Write("Enter First Name:");
                string firstName = Console.ReadLine();
                Console.Write("Enter Middle Name (Press enter to skip):");
                string middleName = Console.ReadLine();
                Console.Write("Enter Last Name:");
                string lastName = Console.ReadLine();
                Console.Write("Enter Salary:");
                salary = int.Parse((Console.ReadLine()));
                Console.WriteLine("Employee Created Successfully!");

                Employee Employee1 = new Employee(employeeId, firstName, middleName, lastName, salary);
                Employee1.DisplayEmployeeInfo();


                Department department1 = new ITDepartment { DepartmentName = "IT Department" };
                Department department2 = new HRDepartment { DepartmentName = "HR Department" };

                department1.DisplayDepartmentInfo();
                department1.Operate();

                department2.DisplayDepartmentInfo();
                department2.Operate();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input, try again");
            }
        }  
    }
}
