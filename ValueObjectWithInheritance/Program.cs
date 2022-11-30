// See https://aka.ms/new-console-template for more information

using ValueObjectWithInheritance;

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
course.Owner = person;
course2.Owner = person2;

context.Courses.Add(course);
context.Courses.Add(course2);
context.SaveChanges();

//fetch
var c1 = context.Courses.First(x => x.Id == 1);
var c2 = context.Courses.First(x => x.Id == 2);