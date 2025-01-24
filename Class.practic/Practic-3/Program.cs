void oddandevenscount(int [] arr){
int even_cnt=0 , odd_cnt=0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i]%2==0){
        even_cnt++;
    }
    if(arr[i]%2!=0){
        odd_cnt++;
    }
}
int [] odd_nums = new int [odd_cnt];
int [] even_nums = new int [even_cnt];
int j=0,k=0;
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] % 2 ==0){
        even_nums[j]=arr[i];
        j++;
    }
    if(arr[i] % 2 !=0){
        odd_nums[k]=arr[i];
        k++;
    }
}

System.Console.Write("Even numbers : [");
int x=0;
foreach (var even in even_nums)
{
    if(x==even_nums.Length)
    System.Console.Write(even + ",");
}
System.Console.Write("]");
System.Console.WriteLine();
System.Console.Write("Odd numbers : [");
int z=0;
foreach (var odd in odd_nums)
{
    System.Console.Write(odd + ",");
}
System.Console.Write("]");
}

int a = Convert.ToInt32(Console.ReadLine());
int []arr = new int [a];
for (int i = 0; i < arr.Length; i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
oddandevenscount(arr);