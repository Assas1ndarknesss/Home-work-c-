int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToChar(Console.ReadLine());
switch (c)
{
    case '+':
        System.Console.WriteLine(a+b);
        break;
    case '-':
        System.Console.WriteLine(a-b);
        break;
    case '*':
        System.Console.WriteLine(a*b);
        break;
    case '/':
         System.Console.WriteLine(a/b);
         break;
    case '%':
        System.Console.WriteLine(a%b);
        break;
    default:
        System.Console.WriteLine("Hey man i don't now what you want to do");
        break;
}