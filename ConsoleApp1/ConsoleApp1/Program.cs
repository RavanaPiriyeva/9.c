using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee();
            employee1.Name = "Revane";
            employee1.Surname = "Piryeva";
            employee1.Salary = 300;



            Employee employee2 = new Employee();
            employee2.Name = "Ayten ";
            employee2.Surname = "Zeynalova";
            employee2.Salary = 300;

            Employee employee3 = new Employee();
            employee3.Name = "Asif";
            employee3.Surname = "Eliyev";
            employee3.Salary = 200;

            Department department = new Department();
            department.EmployeeLimit = 3;
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);


            //!!!!DEYERLERI CONSOLEDE OZMZ DAXIL ETMEK UCUN !!!//

            //Department department = new Department();
            //Console.WriteLine("Limiti daxil edin");
            //department.EmployeeLimit = Convert.ToInt32(Console.ReadLine());
            //while (department.EmployeeLimit > department.Employees.Length) {
            //Console.WriteLine("Adi daxil edin");
            //string name = Console.ReadLine() ;
            //Console.WriteLine("Soyadi daxil edin ");
            //string surname = Console.ReadLine() ;
            //Console.WriteLine("Masi daxil edin ");
            //int salary = Convert.ToInt32(Console.ReadLine()) ; 
            //Employee employee = new Employee() ;
            //employee.Name = name ;
            //employee.Surname = surname ;
            //employee.Salary = salary;
            //department.AddEmployee(employee);
            //}


            Console.WriteLine("==============================ISCILER==============================");
            foreach (var item in department.Employees)
            {
               
                Console.WriteLine($"Ad: {item.Name}               Soyad:{item.Surname}             Maas:{item.Salary}");
            }
        }
    }
}
