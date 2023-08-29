using System;

public class Person
{
    public string Name { get; set; }
    public string BirthDate { get; set; }
    public string WorkPhoneNumber { get; set; }
    public string CellPhoneNumber { get; set; }

    public override string ToString()
    {
        return $"{Name}\n{BirthDate}\nwork {WorkPhoneNumber}\ncell {CellPhoneNumber}";
    }
}

public class Program
{
    public static void Main()
    {
        var samplePerson = new Person 
        {
            Name = "Lucinda Potter",
            BirthDate = "6/24/1992",
            WorkPhoneNumber = "000-000-0101",
            CellPhoneNumber = "000-000-0189"
        };
        Console.WriteLine(samplePerson);
    }
}
