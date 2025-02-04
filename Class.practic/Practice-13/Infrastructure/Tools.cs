using System.ComponentModel;

namespace Infrastructure;

public class Tools
{
    // public void CountWords(string text){
    //     string[] words = text.Split(new []{' ','!',' '});
    //     // foreach (var item in words)
    //     // {
    //     //  System.Console.WriteLine(item);   
    //     // }
    //     Dictionary<string,int> countwords = new Dictionary<string, int>();
    //     // string[] unique = words.Distinct().ToArray();
    //   foreach (var item in words)
    //   {
    //     string cleanword = item.ToLower();
    //     if (countwords.ContainsKey(cleanword))
    //     {
    //         countwords[cleanword] = countwords[cleanword] + 1 ;
    //     }
    //     else if(item== ""){
    //         continue;
    //     }
    //     else{
    //     countwords.Add(cleanword,1);
    //     }
    //   }
    //     System.Console.WriteLine("Quantity:");
    //     int num = 1 ;
    //   foreach (var item in countwords)
    //   {
    //     System.Console.WriteLine($"{num} {item.Key} - {item.Value} раз(а)");
    //     num++;

    //   }
    // }

Dictionary<string,string> Phone = new Dictionary<string, string>();
public Tools(string name, string number){
    if (!Phone.ContainsKey(name))
    {
        Phone[name]=number;
        System.Console.WriteLine($"Контакт добавлен: {name}");
        System.Console.WriteLine($"Найден номер: {number}");
}
else{
    System.Console.WriteLine("Нету такого контакта");
}
}
public void RemoveNums(string name , string number ){
if (Phone.ContainsKey(name))
{
System.Console.WriteLine($"Контакт: {name} успешно удален");
}
else
{
    System.Console.WriteLine("Нету такого контакта");
}
}
public void ShowAllContacts(){
    int cnt = 1;
    if (Phone.Count==0)
    {
        System.Console.WriteLine("Список пуст");
    }
    System.Console.WriteLine("Все контакты");
foreach (var item in Phone)
{
 System.Console.WriteLine($"{cnt}. {item.Key}: {item.Value} ");   
 cnt++;
}
}
}
