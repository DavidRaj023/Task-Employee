using Task.Model;
using Task.Services;

public class programe{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome to Employee Management System");
        
        int choice = 0;
        
        List<Employee> employeesList = new List<Employee>();
        EmployeeDAO.GenerateTempEmp(employeesList);

        Main_Menu:
        Console.WriteLine("Select one of the following options");
        Console.WriteLine("1. Add an Employee" +
            "\n2. Display Employees " +
            "\n3. Update an Employee" +
            "\n4. Remove an Employee" +
            "\n5. Exit");
        Console.WriteLine("Enter your choice: ");
        string input = Console.ReadLine();
        
        while (true)
        {
            if(int.TryParse(input, out choice))
            {
                if(choice == 5) { break; }
                switch (choice)
                {
                    case 1:
                        EmployeeDAO.Create(employeesList);
                        break;
                    case 2:
                        EmployeeDAO.GetAll(employeesList);
                        break;
                    case 3:
                        EmployeeDAO.Update(employeesList);
                        break;
                    case 4:
                        EmployeeDAO.Delte(employeesList);
                        break;
                    default:
                        Console.WriteLine("Choice invaild, Try Again");
                        Console.Write("\nEnter Your Choice : ");
                        input = Console.ReadLine();
                        break;
                }

                goto Main_Menu;
            }
            else
            {
                Console.WriteLine("Choice invaild, Try Again");
                Console.Write("\nEnter Your Choice : ");
                input = Console.ReadLine();
            }
            
        }

    }
}