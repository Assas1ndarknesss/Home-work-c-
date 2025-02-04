KeyValuePair<int , string> MikeTayson = new KeyValuePair<int, string>(50,"Tayson");
KeyValuePair<int , string> Canelo = new KeyValuePair<int, string>(30,"Canelo");
var employ = new List<KeyValuePair<int,string>>(){MikeTayson,Canelo};
var people = new Dictionary<int ,string>(employ);
foreach (var item in people)
{
    System.Console.WriteLine(item);
}
