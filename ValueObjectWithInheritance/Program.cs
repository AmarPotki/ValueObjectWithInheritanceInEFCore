using ValueObjectWithInheritance;
using ValueObjectWithInheritance.Entities;

Console.WriteLine("Hello, World!");

var context = new ApplicationContext();

var person = new Manager
(
    "It",
    "Amar - manager",
    "Potki"
);
var person2 = new Author(

    "Subject ",
    "Amar - Author",
    "Potki"
);
var course = new Course();
var course2 = new Course();
course.SetOwner( person);
course2.SetOwner(person2);

context.Courses.Add(course);
context.Courses.Add(course2);
context.SaveChanges();

//fetch
var c1 = context.Courses.First(x => x.Id == 1);
var c2 = context.Courses.First(x => x.Id == 2);
Console.ReadLine();
