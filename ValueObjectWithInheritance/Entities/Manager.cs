namespace ValueObjectWithInheritance.Entities;

public class Manager : Person
{
    public Manager(string? department, string firstName, string lastName) : base(firstName, lastName)
    {
        Department = department;
    }

    public string? Department { get; set; }
}