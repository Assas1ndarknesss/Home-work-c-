// System.Console.WriteLine("Создаем студента...");
// System.Console.Write("Имя: ");
// string name =Console.ReadLine();
// Student bezhan = new Student(name);
// System.Console.WriteLine("Добавляем оценки:");
// string  []av =  Console.ReadLine().Split(",");
// bezhan.Input(av);
// bezhan.ShowGrades();
// class Student
// {
//     public string Name;
//     public int[] Grades;

//     public Student(string name){
//         Name=name;
//     } 
//     public void Input(string[] grades){
//    this.Grades = new int [grades.Length];
//    for (int i = 0; i < Grades.Length; i++)
//    {
//     Grades[i]=Convert.ToInt32(grades[i]);
//    }
//     }
//     public double GetAverage(){
//         double cnt=0;
//         double sum=0;
//         for (int i = 0; i < Grades.Length; i++)
//         {
//             sum+=Grades[i];
//             cnt++;
//         }
//         return (sum/cnt);
//     }
//     public void ShowGrades(){
//         System.Console.WriteLine("Информация о студенте:");
//         System.Console.WriteLine($"Студент: {Name}");
//         System.Console.Write($"Оценки:");
//         for (int i = 0; i < Grades.Length; i++)
//         {
//             System.Console.Write(Grades[i]);
//             System.Console.Write(",");

//         }
//         System.Console.WriteLine($"\nСредний балл: {GetAverage()}");
//     }
// }
// Teacher Jerom = new Teacher("Jon","Physic",18);
// System.Console.WriteLine(Jerom.Teach());

// System.Console.Write("New year:");
// int year=Convert.ToInt32(Console.ReadLine());
// Jerom.SetExp(year);
// System.Console.WriteLine();
// Jerom.Show();
// class Teacher
// {
//   private string FullName;

//   private string subject;
//   private int  experiens;

//   public Teacher(){
//     System.Console.WriteLine("Your teacher:");
//   }
//   public Teacher (string name,string subject){ 
//      FullName=name;
//      this.subject=subject;
//   }
// public Teacher(string name,string subject, int experiens){
//      FullName=name;
//      this.subject=subject;
//      this.experiens=experiens;
// }
// public string Teach(){
//     return $"{FullName} is teaching {this.subject}";
// }
// public void SetExp(int years){
//     experiens += years;
// }
// public void Show(){
// System.Console.WriteLine($"Name:{FullName}");
// System.Console.WriteLine($"Subject:{subject}");
// System.Console.WriteLine($"Experiens:{experiens}");
// }

// }
using System.Diagnostics;

Hero Joni = new Hero("Ahiles",10,80,0);
System.Console.Write("Choose comand:");
for(;;){
  string n = Console.ReadLine();
if (n=="Info"){
  Joni.ShowItem();
}
if (n=="Attacking"){
  System.Console.Write("Damage:");
  int damage = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Герой получает урон ({damage})...");

Joni.TakeDamage(damage);
}
if (n=="Healing"){
  System.Console.Write("Heal:");
  int damage = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Герой лечится ({damage})...");
Joni.Heal(damage);
}
if (n=="Level Up"){
  System.Console.WriteLine("Герой получает новый уровень!");
Joni.LevelUp();
}
if (n=="Add item"){
  System.Console.Write("New Item:");
  string d = Console.ReadLine();
Joni.AddItem(d);
}
else{System.Console.WriteLine("Please choose command");}

}
class Hero
{
  public string Name;
  public int Health;
  public int Level;
  public string[] Items;
  private int index = 0;
  public Hero(string name,int ml,int health=100, int level = 1)
  {
    this.Name = name;
    this.Items = new string[ml];
    Health=health;
    this.Level=level;
  }
  public void TakeDamage(int damage)
  {
    if (Health < 1)
    {
      System.Console.WriteLine($"{Name} is died");
      Health = 0;
      
    }
  
    this.Health -= damage;

System.Console.WriteLine($"Здоровье:  {Health}");
  }
  public void Heal(int damage)
  {
    this.Health += damage;
    if (Health > 100)
    {
      Health = 100;
    }
System.Console.WriteLine($"Здоровье:  {Health}");
  }
  public void LevelUp(){
    Level+=1;
    System.Console.WriteLine($"New level: {Level}");
  }
  public void AddItem(string item)
  { 
    if(index<Items.Length){
    Items[index]=item;}
    
  }
  public void ShowItem()
  {
    System.Console.WriteLine($"Name: {Name}");
    System.Console.WriteLine($"Health: {Health}");
    System.Console.WriteLine($"Level: {Level}");
    System.Console.Write($"Items:");
    for (int i = 0; i < Items.Length; i++)
    {
      if(Items[0]==null){
        System.Console.Write("Empty");
        break;
      }
      if(Items[i]==null){
      System.Console.Write($"{Items[i]} ");
      }
      break;
    }


  }
}


