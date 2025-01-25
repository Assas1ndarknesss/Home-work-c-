using Infrastructure;

Student student = new Student();
System.Console.Write("New Student:");
student.Name = Console.ReadLine();
System.Console.Write("Age:");
student.Age = Convert.ToInt32(Console.ReadLine());
student.Grades = new []{5,5,5,5};

StudentManager manager = new StudentManager();
manager.Addstudent(student); 
// manager.Remove (1); 
// manager.ShowAllStudents();
// manager.FindByName("Shoruh");
System.Console.WriteLine();
// manager.GetExecellentStudents(student);
// manager.GetAverageAge();
// manager.FindYoungestStudent();
// manager.FindOldestStudent();
manager.SortByAge();