using System.ComponentModel.DataAnnotations.Schema;
using ValueObjectWithInheritance.BuildingBlocks;

namespace ValueObjectWithInheritance.Entities
{
    public class Course : IAggregateRoot
    {
        public int Id { get; set; }
        private PersonContainer _personContainer;

        public void SetOwner(Person owner)
        {
            Owner = owner;
        }

        [NotMapped]
        public Person Owner
        {
            get => _personContainer.Person;
           private set
            {
                _personContainer = new();
                _personContainer.Person = value;
            }
        }
    }
}
