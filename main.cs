using System;

public class Person
{
    public string Name { get; set; }
    public string BirthDate { get; set; }
    public string WorkPhoneNumber { get; set; }
    public string CellPhoneNumber { get; set; }
}

public static class PersonalInfo
{
    public static string Display(Person person)
    {
        return $"{person.Name}\n{person.BirthDate}\nwork {person.WorkPhoneNumber}\ncell {person.CellPhoneNumber}";
    }
}

public class Program
{
    public static void Main()
    {
        // Sample data for demonstration
        Person samplePerson = new Person 
        {
            Name = "Francisco Isaac",
            BirthDate = "01/16/2002",
            WorkPhoneNumber = "813-847-3797",
            CellPhoneNumber = "813-847-3797"
        };
        Console.WriteLine(PersonalInfo.Display(samplePerson));
    }
}
