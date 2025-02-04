// // using System.ComponentModel.DataAnnotations;

// // User user = new User();
// // user.ViewActivity();

// // RegularUser regularUser = new RegularUser();
// // regularUser.ViewActivity();

// // Influencer influencer = new Influencer();
// // influencer.ViewActivity();

// // class User 
// // {
// //   public virtual void ViewActivity() 
// //   {
// //    System.Console.WriteLine("User: My Activity is Last month");
// //   }
// // }

// // class RegularUser : User   
// // {
// //   public override void ViewActivity() 
// //   {
// // System.Console.WriteLine("Bilolger: My followers active Yesterday");
// //   }
// // }

// // class Influencer : User 
// // {
// //   public override void ViewActivity() 
// //   {
// // System.Console.WriteLine("Influencer: Active");
// //   }
// // }


// // class Photo
// // {
// //     public virtual void Display(){
// //         System.Console.WriteLine("It's your picture");
// //     }

// // }

// // class ProcessedPhoto : Photo
// // {
// //     public override void Display()
// //     {
// //         System.Console.WriteLine("Your picture with black Filter");
// //     }
// // }
// Shape shape = new Shape();

// Circle circle = new Circle(10);

// Rectangle rectangle = new Rectangle(10, 20);

// Square square = new Square(4);

// Triangle triangle = new Triangle(10, 15, 20);

// List<Shape> shapes = new List<Shape>();

// shapes.Add(circle);
// shapes.Add(rectangle);
// shapes.Add(square);
// shapes.Add(triangle);

// System.Console.WriteLine();

// foreach (var item in shapes)
// {
//     System.Console.WriteLine($"Area : {item.Area()} Perimetr : {item.Perimetr()}");
//     System.Console.WriteLine();
// }

// class Shape
// {

//     public virtual double Area()
//     {
//         return 0;
//     }
//     public virtual double Perimetr()
//     {
//         return 0;
//     }
// }

// class Circle : Shape
// {
//     private double r;
//     public const double PI = 3.14;
//     public Circle(double r)
//     {
//         this.r = r;
//     }
//     public override double Perimetr()
//     {
//         double res = PI * r * 2;
//         return res;
//     }

//     public override double Area()
//     {
//         double res = PI * r;
//         return res * res;
//     }


// }

// class Rectangle : Shape
// {
//     double Width;
//     double Height;
//     public Rectangle(double widht, double Height)
//     {
//         this.Width = widht;
//         this.Height = Height;
//     }
//     public override double Perimetr()
//     {
//         return this.Width + this.Height * 2;
//     }

//     public override double Area()
//     {
//         return this.Width * this.Height;
//     }


// }

// class Square : Shape
// {
//     double Width;
//     public Square(double widht)
//     {
//         this.Width = widht;
//     }
//     public override double Perimetr()
//     {
//         return this.Width * 2;
//     }
//     public override double Area()
//     {
//         return this.Width * this.Width;
//     }


// }

// class Triangle : Shape
// {
//     double Width;
//     double Width2;
//     double Height;
//     public Triangle(double widht, double height, double widht2)
//     {
//         this.Width = widht;
//         this.Width2 = widht2;
//         this.Height = height;
//     }
//     public override double Perimetr()
//     {
//         return this.Width + this.Width2 + this.Height;
//     }

//     public override double Area()
//     {
//         return this.Width * this.Width2 * this.Height;
//     }
// }
using System.Diagnostics.CodeAnalysis;

DateTime Week = new DateTime(2020,01,30,12,20,10);
DateTime Week2 = new DateTime(2024,01,30,12,20,10);
System.Console.WriteLine(Week2.Subtract(Week));
Console.WriteLine(Week.ToLongDateString());
System.Console.WriteLine($"{Week:t}");