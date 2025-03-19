using System.ComponentModel.DataAnnotations;

namespace StartCsharp1.DataModels;

public class Employee
{
    private  static List<Employee> employees = new List<Employee>();
    
    public string Enrollement { get; set; }
    public string Name { get; set; } //a property that is public and has a getter and setter
    public string Surname { get; set; }
    public MainEnumerators.Gender Gender { get; set; }
    public string City { get; set; }
    public int Age { get; set; }

    public Employee()
    {
        Enrollement = string.Empty;
        Name = string.Empty;
        Surname = string.Empty;
        Gender = MainEnumerators.Gender.None;
        City = string.Empty;
        Age = 0;
    }

    public Employee (string enrollement, string name, string surname, MainEnumerators.Gender gender, string city, int age)
    {
        Enrollement = enrollement;
        Name = name;
        Surname = surname;
        Gender = gender;
        City = city;
        Age = age;
    }

    public void AddEmployee( Employee employee)
    {

        Console.Write("Enrollement: ");
        employee.Enrollement = Console.ReadLine() ?? "Unknown";

        Console.Write("Name: ");
        employee.Name = Console.ReadLine() ?? "Unknown";

        Console.Write("Surname: ");
        employee.Surname = Console.ReadLine() ?? "Unknown";

        Console.Write("Gender (1 for Male, 2 for Female): ");
        int genderInput = int.TryParse(Console.ReadLine(), out int gender) ? gender : 0;
        employee.Gender = (MainEnumerators.Gender)genderInput;

        Console.Write("City: ");
        employee.City = Console.ReadLine() ?? "Unknown";

        Console.Write("Age: ");
        employee.Age = int.TryParse(Console.ReadLine(), out var age) ? age : 0;

        // Add employee to the shared list
        employees.Add(employee);

        Console.WriteLine($"\nEmployee added successfully: {employee.Name} {employee.Surname}");

        
    }

    public void ShowEmployee()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found.");
        }
        else
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Enrollement: {employee.Enrollement}");
                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Surname: {employee.Surname}");
                Console.WriteLine($"Gender: {employee.Gender}");
                Console.WriteLine($"City: {employee.City}");
                Console.WriteLine($"Age: {employee.Age}");
                Console.WriteLine();
            }
        }
    }
}