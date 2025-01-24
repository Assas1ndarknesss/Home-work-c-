// student Number1 = new student();
//  Number1.first_name = "Jonathan";
//  Number1.last_name = "Fiesto";
//  Number1.age = 23;
//  Number1.adress = "Italy";
//  Number1.grades = new int []{80,90,70,60};

//  string res = Number1.getinfo();
//  System.Console.WriteLine(res);

// string result = Number1.average();
// System.Console.WriteLine(result);
// class student
// {
//     public string? first_name;
//     public string? last_name;
//     public int age;
//     public string? adress;
//     public int [] grades;

// public string getinfo(){
//     return $"Full name: {first_name} {last_name}, Age: {age}, Adress: {adress}";
// }
// public string average(){
//     int sum=0;
//     for (int i = 0; i < grades.Length; i++)
//     {
//         sum+=grades[i];
//     }
//     return $"Average: {sum / grades.Length}";
// }

// }
// Car car_1 = new Car ();
// car_1.model = Console.ReadLine();
// car_1.color = Console.ReadLine();
// car_1.pub_year = 2000;
// car_1.horse_power = "380";
// car_1.country = "Tokyo";
// car_1.price = "500.000$";

// string all = car_1.getinfo();
// System.Console.WriteLine(all);

// string ml = car_1.drive();
// System.Console.WriteLine(ml);

// class Car
// {
//     public string? model;
//     public string? color;
//     public int? pub_year;
//     public string?  horse_power;
//     public string? country;
//     public string?  price;

// public string getinfo(){
//     return $"Model: {model} Color: {color}, Born-data: {pub_year} Year, Country: {country}, Price: ({price}) ";
// }
// public string drive(){
//     int mil = Convert.ToInt32(horse_power)/2;
//     return $"{mil}" + " Mile/h";
//     }

// }
Calculator calculator = new Calculator ();
calculator.num=Convert.ToInt32(Console.ReadLine());
calculator.num1=Convert.ToInt32(Console.ReadLine());
 int pluss = calculator.plus();
 System.Console.WriteLine(pluss);
 
 int minuss = calculator.minus();
 System.Console.WriteLine(minuss);

 int multiplyy = calculator.multiply();
 System.Console.WriteLine(multiplyy);

 double dividee = calculator.divide();
 System.Console.WriteLine(dividee);

 double modulee = calculator.module();
 System.Console.WriteLine(modulee);

class Calculator
{
    public int? num;
    public int? num1;

public int plus(Calc){
   int res= (num + num1);
   return res;
}
public int minus(){
    int num=Convert.ToInt32(Console.ReadLine()) ,  num1=Convert.ToInt32(Console.ReadLine());
   int res= (num - num1);
   return res;
}
public int multiply(){
    int num=Convert.ToInt32(Console.ReadLine()) ,  num1=Convert.ToInt32(Console.ReadLine());
   int res= (num * num1);
   return res;
}
public double divide(){
    int num=Convert.ToInt32(Console.ReadLine()) , num1=Convert.ToInt32(Console.ReadLine());
   double res= (num / num1);
   return res;
}
public int module(){
    int num=Convert.ToInt32(Console.ReadLine()) , num1=Convert.ToInt32(Console.ReadLine());
   int res= (num % num1);
   return res;
}

}