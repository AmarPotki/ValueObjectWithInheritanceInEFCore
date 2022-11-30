namespace ValueObjectWithInheritance;

public class Author : Person
{

    public Author(string? subjectArea, string firstName, string lastName) : base(firstName, lastName)
    {
        SubjectArea = subjectArea;
    }

    public string? SubjectArea { get; set; }
}