using System.ComponentModel.DataAnnotations;

namespace StartCsharp1.DataModels;

public class Employee
{
    List<Employee> employees = new List<Employee>();
    
    [Key]
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

    public Employee(string enrollement, string name, string surname, MainEnumerators.Gender gender, string city, int age)
    {
        Enrollement = enrollement;
        Name = name;
        Surname = surname;
        Gender = gender;
        City = city;
        Age = age;
    }
}