namespace Infrastructure;

public class StudentManager
{
    private List<Student> Students = new List<Student>();
    private int id = 1;
    private bool deleted = true;
    private bool find = true;
    public void Addstudent(Student student)
    {
        student.Id = id;
        Students.Add(student);
        id++;
        System.Console.WriteLine("Студент успешно добавлен:");
        System.Console.WriteLine($"Id: {this.id}");
        System.Console.WriteLine($"Name: {student.Name}");
        System.Console.WriteLine($"Age: {student.Age}");
        System.Console.Write($"Grades: {student.Grades}");
        foreach (var grade in student.Grades)
        {
            System.Console.Write(grade + ",");
        }
        id++;
    }

    public void Remove(int id)
    {
        System.Console.WriteLine("                  ");
        foreach (var student in Students)
        {
            if (student.Id == id)
            {
                Students.Remove(student);
                System.Console.WriteLine($"Студент с Id {id} успешно удален");
                deleted = false;
            }
            if (deleted)
            {
                System.Console.WriteLine($"Ошибка: Студент с Id {id} не найден");
            }
        }
    }
    public void ShowAllStudents()
    {
        foreach (var student in Students)
        {
            System.Console.WriteLine($"{student.Id}. {student.Name}. {student.Age} - Grades: ");
            foreach (var grade in student.Grades)
            {
                System.Console.Write(grade + ",");
            }
        }
    }
    public void FindByName(string name)
    {
        foreach (var item in Students)
        {
            if (item.Name.ToLower().Contains(name.ToLower()))
            {
                Console.WriteLine();
                System.Console.Write($"{item.Id}. {item.Name}. {item.Age} - Grades: ");
                foreach (var grade in item.Grades)
                {
                    System.Console.Write(grade + ",");

                }
                Console.WriteLine();
                find = false;

            }
        }
        if (find)
        {
            System.Console.WriteLine($"Студенты с именем {name} не найдены");
        }

    }
    public void GetExecellentStudents(Student student)
    {
        int cnt = 0;
        foreach (var item in Students)
        {
            foreach (var grade in item.Grades)
            {
                if (grade == 5)
                {
                    cnt++;
                }
            }
            if (cnt >= 1 && cnt < item.Grades.Count())
            {
                System.Console.Write($"{student.Name} ({student.Age}) - Eсть оценки: ");
                foreach (var grade2 in student.Grades)
                {
                    System.Console.Write(grade2 + ",");
                }
            }
            if (cnt == item.Grades.Count())
            {
                System.Console.Write($"{student.Name} ({student.Age}) - Вcе оценки: ");
                foreach (var grade1 in student.Grades)
                {
                    System.Console.Write(grade1 + ",");
                }
            }
        }

    }

    public void GetAverageAge()
    {
        int sum = 0;
        foreach (var student in Students)
        {
            sum += student.Age;
        }
        System.Console.WriteLine();
        System.Console.WriteLine($"Средний возраст студентов:{sum / Students.Count} лет");
    }

    public void FindYoungestStudent()
    {
        int min = 99;
        string name = "";
        foreach (var Studentyear in Students)
        {
            if (Studentyear.Age < min)
            {
                min = Studentyear.Age;
                name = Studentyear.Name;
            }
        }
        System.Console.WriteLine($"Самый молодой студент: {name} ({min} лет)");
    }
    public void FindOldestStudent()
    {
        int max = -99;
        string name = "";
        foreach (var Studentyear in Students)
        {
            if (Studentyear.Age > max)
            {
                max = Studentyear.Age;
                name = Studentyear.Name;
            }
        }
        System.Console.WriteLine($"Самый взрослый студент: {name} ({max} лет)");
    }

    public void SortByAge()
    {
        System.Console.WriteLine();
        for (int i = 0; i < Students.Count - 1; i++)
        {
            for (int j = 0; j < Students.Count - i - 1; j++)
            {
                if (Students[j].Age > Students[j + 1].Age)
                {
                    var Luboychi=Students[j];
                    Students[j] = Students[j + 1];
                    Students[j + 1] = Luboychi;
                }

            }

        }
                int cnt = 1;
                System.Console.WriteLine("Студенты по возрасту:");
                foreach (var Student in Students)
                {
                    System.Console.WriteLine($"{cnt}. {Student.Name} ({Student.Age} лет)");
                    cnt++;
                } 
    }


}