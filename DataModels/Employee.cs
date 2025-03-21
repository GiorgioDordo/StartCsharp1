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

    public void AddEmployee(Employee employee)
    {
        int enrollmentInt = -1; // Initialize enrollmentInt with a starting value
        enrollmentInt++;
        employee.Enrollement = enrollmentInt.ToString();
        employees.Add(new Employee { Enrollement = "128", Name = "John", Surname = "Doe", Gender = MainEnumerators.Gender.Male, City = "New York", Age = 25});
        employees.Add(new Employee { Enrollement = "456", Name = "Jane", Surname = "Doe", Gender = MainEnumerators.Gender.Female, City = "New York", Age = 25});
        employees.Add(new Employee { Enrollement = "789", Name = "John", Surname = "Smith", Gender = MainEnumerators.Gender.Male, City = "New York", Age = 25});

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
    
    public string EmployeeValues()
    {
        return $"{Enrollement};{Name};{Surname};{Gender};{City};{Age}";
    }

    public void SaveEmployees()
    {
        Console.Clear();
        try
        {
            // I save all the employees in this new list of strings, in wich I save every new employee I create.
            List<string> employeesString = new List<string>();

            Console.WriteLine("Salvataggio dei dati in corso...");
            
            Console.WriteLine();
            
            //For each `employee`, I call a method (`EmployeeValues`) to get a string representation and add it to the list.
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.EmployeeValues());
                // I use the EmployeeValues method on the employee object 
                //the returned string is added to the employeeString list
                employeesString.Add(employee.EmployeeValues());
            }

            // the file path where  the employees data will be saved
            // this is an absolute path to the text file on my sistem
            // in C# I need t use double backslashes (\\) because in C# , the backslash is an escape characther
            string filePath = "C:\\Users\\dekan\\OneDrive\\Desktop\\Betacom\\StartCsharp1\\employees.txt";
            
            /* File.WriteAllText - is  a method provided by the System.IO namespace that writes text to a file, If the file Already exists,
               it overwrites the content */
            /* Then I join all strings in my list into a single string, separating each string with a new line (Environment.NewLine)  */
            //File.WriteAllText(filePath, string.Join(Environment.NewLine, employeesString));
            
            File.AppendAllLines(filePath, employeesString);
            
            string filePath2 = "C:\\Users\\dekan\\OneDrive\\Desktop\\Betacom\\StartCsharp1\\employees2.txt";
            // apro un flusso di scrittura su filePath
            StreamWriter streamWriter = new StreamWriter( filePath2);

            foreach (Employee employee in employees)
            {
                streamWriter.WriteLine(employee.EmployeeValues());
            }
            // streamWriter should be always closed (anyway it should close itself)
            streamWriter.Close();

            string filePath3 = "C:\\Users\\dekan\\OneDrive\\Desktop\\Betacom\\StartCsharp1\\employees3.txt";
            // If I use using I don't need to use streamWriter.Close();
            using (StreamWriter streamWriter2 = new StreamWriter( filePath3))
            {
                foreach (Employee employee in employees)
                {
                    streamWriter2.WriteLine(employee.EmployeeValues());
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Salvataggio dei dati effettuato con successo!");
            Console.ResetColor();
        }
        catch (Exception e)
        {
            Console.WriteLine("Si è presentato un errore surante il salvataggio dei dati: " + e.Message);
            throw; // Rethrow the exception after logging it
        }
    }

    //da completare
    public void RemoveEmployee(Employee employee)
    {
    }
}