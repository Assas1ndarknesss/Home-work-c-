using Infrastructure;

// tools.CountWords("Hello world! it is me world hello it is not me");
System.Console.Write("Name:");
string name;
name = Console.ReadLine();
System.Console.Write("Numbers:");
string number;
number = (Console.ReadLine());
Tools tools = new Tools(name,number);
tools.ShowAllContacts();
