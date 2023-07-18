using EntityFrameworkCoreExample;

using StudentContext dbContext = new();

// Add with EF Core

Student s = new()
{
	FullName = "John Bartholomew",
	EmailAddress = "jBart@blah.com",
	DateOfBirth = new DateTime(2000, 1, 1)
};

Student s2 = new()
{
	FullName = "Joe Ortiz",
	EmailAddress = "jOrt@blah.com",
	DateOfBirth = new DateTime(2000, 1, 1)
};

dbContext.Students.Add(s); // prepares the student insert statement

dbContext.SaveChanges(); // executes any pending insert/update/delete queries

dbContext.Students.Add(s2);
dbContext.SaveChanges();

// Retrieve Students from DB
List<Student> allStudents = dbContext.Students.ToList(); // method syntax
// allStudents = (from stu in dbContext.Students
//			  select stu).ToList(); // query syntax

foreach (Student stu in allStudents)
{
	Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
	Console.WriteLine();
}

Console.ReadLine();