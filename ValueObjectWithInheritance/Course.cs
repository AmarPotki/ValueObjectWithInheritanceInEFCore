using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObjectWithInheritance
{
    public class Course
    {
        public int Id { get; set; }
        private PersonContainer _personContainer;

        [NotMapped]
        public Person Owner
        {
            get => _personContainer.Person;
            set
            {
                _personContainer = new PersonContainer();
                _personContainer.Person = value;
            }
        }
    }
}
