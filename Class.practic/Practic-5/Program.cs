User user1 = new User();
System.Console.Write("Firstname:");
string first = Console.ReadLine();
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.Write("Lastname:");
string last = Console.ReadLine();
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.Write("Username:");
string userr = Console.ReadLine();
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.Write("Password:");
string password = Console.ReadLine();
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.Write("Email:");
string Email = Console.ReadLine();
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("Finish your registration");
user1.register(first,last,userr,password,Email);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("Login->");
user1.login(userr,password);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("<-Logout");
user1.logout(userr);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("Change Password");
user1.newpassword(password);


class User
{
 private string? username;
 private string? password;
 public string ? email ;
 public string ?  firstname;
 public string ?  lastname;

 public string register(string firstname,string lastname,string username,string password, string email){
    this.firstname=firstname;
    this.lastname=lastname;
    this.username=username;
    this.password=password;
    this.email=email;
   if(password.Length<5){
    return "Password need to have more than 5 simbols";
   }
   else return "Succsesfuly finish";
 }
 public string login(string username,string password){
    if (this.password==password && this.username==username){
        return "You alredy in account";
    }
    else return "No password or username is incorect";
 }
public string logout(string username){
           if(this.username==username){
            return "Hazor Rahmat";
           }
           else return "Hato kadi rodoy";
}

 public string newpassword(string pasword){
if (this.password==pasword){
   
    return this.password=Console.ReadLine()+("Password changed");
    
}
else return "Old password is incorect";
 }
}
