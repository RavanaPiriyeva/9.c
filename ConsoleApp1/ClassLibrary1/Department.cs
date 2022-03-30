using System;
using System.Collections.Generic;
using System.Text;


namespace ClassLibrary1
{
    public class Department
    {

        public Department()
        {
            this.Employees=new Employee[0];
        }
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int SalaryLimit { get; set; }
        public Employee[] Employees;


        public void AddEmployee(Employee  employees)
        {
            if (EmployeeLimit > Employees.Length)
            {
                Array.Resize(ref Employees, Employees.Length+1);
                Employees[Employees.Length - 1] = employees;

            }
            else
            {
                Console.WriteLine("Limiti kecmisiz");
            }
        }

    }
}
