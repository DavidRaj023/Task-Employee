using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Model;

namespace Task.Services
{
    public class EmployeeDAO
    {
        public static void GenerateTempEmp(List<Employee> employeesList)
        {
            try
            {
                Employee employee = new Employee();
                employee.EmpId = 1;
                employee.FirstName = "David";
                employee.LastName = "Raj";
                employee.Dob = DateOnly.Parse("2000/2/23");
                employee.Email = "benjamindavid023@gmail.com";
                employeesList.Add(employee);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Create(List<Employee> employeesList)
        {
            try
            {
                Console.WriteLine("Add an Employee\n");
                Employee emp = new Employee();

                Console.WriteLine("Enter Employee First Name");
                emp.FirstName = Console.ReadLine();

                Console.WriteLine("Enter Employee Last Name");
                emp.LastName = Console.ReadLine();

                Console.WriteLine("Enter Employee Dob");
                emp.Dob = DateOnly.Parse(Console.ReadLine());

                Console.WriteLine("Enter Employee Email Address");
                emp.Email = Console.ReadLine();

                emp.EmpId = employeesList.Count + 1;

                employeesList.Add(emp);

                Console.WriteLine("New Employee Details Added Successfully With Employee id: {0}\n\n", emp.EmpId);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void GetAll(List<Employee> employeesList)
        {
            try
            {
                Console.WriteLine("Display Employees\n");
                Console.WriteLine("\t\t-------Empolyee Details-------");
                Console.WriteLine("\n\tID \t Name \t\tDoB\t\t\t Email");
                //Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|", "Id", "Name", "Email"));
                //employeesList.ForEach(emp => Console.WriteLine("\n\t" + emp.EmpId + "\t" + emp.FirstName +" "+ emp.LastName + "\t" + emp.Email + "\n\n"));
                foreach (Employee emp in employeesList)
                {
                    Console.WriteLine("\t{0}\t{1}\t{2}\t\t{3}", emp.EmpId, emp.FirstName + " " + emp.LastName, emp.Dob, emp.Email);
                    //Console.WriteLine(String.Format("|{0,5}|{1,5}|{2,5}|", emp.EmpId, emp.FirstName + " " + emp.LastName, emp.Email));
                    //Future Enhance:
                    //https://stackoverflow.com/questions/856845/how-to-best-way-to-draw-table-in-console-app-c
                }

                Console.WriteLine("\n");
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void Update(List<Employee> employeesList)
        {
            try
            {
                Console.WriteLine("Remove an Employee\n");
                Console.WriteLine("Enter Employee Id to Update Details: ");
                int empid = Convert.ToInt32(Console.ReadLine());

                Employee emp = new Employee();

                var empinfo = employeesList.Where(employee => employee.EmpId == empid).FirstOrDefault();

                if (empinfo != null)
                {
                    Console.WriteLine("Enter First Name");
                    emp.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name");
                    emp.LastName = Console.ReadLine();
                    Console.WriteLine("Enter Date of birth");
                    emp.Dob = DateOnly.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Email Address");
                    emp.Email = Console.ReadLine();

                    employeesList.Where(employee => employee.EmpId == empid).FirstOrDefault().FirstName = emp.FirstName;
                    employeesList.Where(employee => employee.EmpId == empid).FirstOrDefault().LastName = emp.LastName;
                    employeesList.Where(employee => employee.EmpId == empid).FirstOrDefault().Dob = emp.Dob;
                    employeesList.Where(employee => employee.EmpId == empid).FirstOrDefault().Email = emp.Email;

                    Console.WriteLine("Employee Details updated...");
                }
                else
                {
                    Console.WriteLine("Given Employee id is not available, Please Try Again...");
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public static void Delte(List<Employee> employeesList)
        {
            try
            {
                Console.WriteLine("Delete");
                Console.WriteLine("Enter the Employee id to Delete");
                int empid = Convert.ToInt32(Console.ReadLine());

                var empinfo = employeesList.Where(employee => employee.EmpId == empid).FirstOrDefault();
                if (empinfo != null)
                {
                    employeesList.Remove(empinfo);
                    Console.WriteLine("Deleted");
                }
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
