// var Num = new List<int>();
// int sum=0;
// int stop;
// for(;;){
//  stop = int.Parse(Console.ReadLine());
//  if(stop==0){
//     break;
//  }
//  Num.Add(stop);
//  sum+=stop;

// }
// System.Console.Write($"{sum}");
////////////////////1/////////////////////
// var Num = new List<int>();
// int stop;
// for(;;){
//  stop = int.Parse(Console.ReadLine());
//  if(stop==0){
//     break;
//  }
//  Num.Add(stop);
// }
// int a = Convert.ToInt32(Console.ReadLine());
// void Search(int a){

// int r=0;     
// int cnt=0;
// foreach (var item in Num)
// {
//     if(a==Num[r]){
//         cnt++;
//     }
//     r++;


// }
// if (cnt>0)
// {
//     System.Console.WriteLine(true);
// }
// else {
//     System.Console.WriteLine(false);
// }
// }
// Search(a);
//////////////////2////////////////////
// var square = new List<int>();
// int num = int.Parse(Console.ReadLine());
// for (int i = 0; i < num; i++)
// {
//     square.Add(int.Parse(Console.ReadLine()));
// }   
// var square2 = new List<int>();
// for (int i = 0; i < num; i++)
// {
//     int r = square[i]*square[i];
//     square2.Add(r);
// }    
// for (int i = 0; i < num; i++)
// {
//     System.Console.Write($"{square2[i]} ");
// }
/////////////////3////////////////
// var square = new List<int>();
// void RemoveEven(List<int> ex)
// {
//     int num = Convert.ToInt32(Console.ReadLine());
//      int b;
//     for (int i = 0; i < num; i++)
//     {    
//         b = Convert.ToInt32(Console.ReadLine());
//           if(b%2==0){
//               continue;
//               }
//         ex.Add(b);
//     }
    
//     foreach (var item in ex)
//     {
//         System.Console.Write(item+" ");
//     }
    
// }
// RemoveEven(square);
////////////////////4///////////////
// var list1 = new List<int>();
// System.Console.Write("Size first list:");
//     int num = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Add numbers:");
//     for (int i = 0; i < num; i++)
//     {
//         list1.Add(Convert.ToInt32(Console.ReadLine()));
//     }
// var list2 = new List<int>();
//     System.Console.WriteLine("Add numbers second list:");
//     for (int i = 0; i < num; i++)
//     {
//         list2.Add(Convert.ToInt32(Console.ReadLine()));
//     }
// var list3 = new List<int>();
// System.Console.WriteLine("Result:");
// for (int i = 0; i < num; i++)
// {
//     list3.Add(list1[i]);
// }
//     for (int j = 0; j < num; j++)
//     {
//         int cnt=0;
//         for (int i = 0; i < num; i++)
//         {
//             if (list3[i]==list2[j])
//             {
//                 cnt++;
//                 break;
//             }
//             if(cnt==0){
//                 list3.Add(list2[i]);
//             }
//         }
//     }
//     foreach (var item in list3)
//     {
//         System.Console.Write(item + "  ");
//     }
/////////////////5///////////////////
// var find = new List<int>();
// int size = Convert.ToInt32(Console.ReadLine());
// int minimum = int.MaxValue;
// int maximum = int.MinValue;
// for (int i = 0; i < size; i++)
// {
//     find.Add(Convert.ToInt32(Console.ReadLine()));
// }
// for (int i = 0; i < size; i++)
// {
//     if (minimum>find[i])
//     {
//         minimum=find[i];
//     }
//     if (maximum<find[i])
//     {
//         maximum=find[i];
//     }
// }
// System.Console.Write("Minimum = " + minimum);
// System.Console.WriteLine();
// System.Console.Write("Maximum = " + maximum);
/////////////////////6/////////////