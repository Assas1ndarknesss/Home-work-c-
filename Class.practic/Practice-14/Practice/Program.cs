Person person = new Person();
Student student = new Student();
Teacher teacher = new Teacher();
person.Greet();

person.Set_Age(99999);

student.Set_Age(21);

teacher.Set_Age(31);

teacher.Explain();

student.Study();

student.ShowAge();

class Teacher:Person
{
    public void Explain(){
        System.Console.WriteLine("Teacher::: I'm explaining");
    }
}

class Student:Person
{
    public void Study(){
        System.Console.WriteLine("Student::: I'm styding man");
    }
    public void ShowAge(){
System.Console.WriteLine($"Studetn::: My age is : {age} years old");
    }
}
class Person
{
    private string _Name;
    protected int age;

public void Set_Age(int age){
this.age=age;
}
  public void Greet(){
    System.Console.WriteLine("Person::: Assalam Aleykum Ahi");
  }

  
}
