using System.ComponentModel.DataAnnotations.Schema;
using ValueObjectWithInheritance.BuildingBlocks;

namespace ValueObjectWithInheritance.Entities;

public class PersonContainer : ValueObject
{
    private PersonType _type;
    private string _firstName;
    private string _lastName;
    private string? _subjectArea;
    private string? _department;
    [NotMapped]
    public Person Person
    {

        get
        {
            switch (_type)
            {
                case PersonType.Author:
                    return new Author(_subjectArea, _firstName, _lastName);

                case PersonType.Manager:
                    return new Manager(_department, _firstName, _lastName);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        set
        {
            switch (value)
            {
                case Manager manager:
                    _department = manager.Department;
                    _subjectArea = null;
                    _type = PersonType.Manager;
                    _firstName = manager.FirstName;
                    _lastName = manager.LastName;
                    break;

                case Author author:
                    _department = null;
                    _subjectArea = author.SubjectArea;
                    _type = PersonType.Author;
                    _firstName = author.FirstName;
                    _lastName = author.LastName;
                    break;
            }
        }
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return _type;
        yield return _firstName;
        yield return _lastName;
    }
}