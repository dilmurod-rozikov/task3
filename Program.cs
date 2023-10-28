var count = 1;
var sum = 0;
while(count != 1000)
{
    if(count % 2 == 1)
        sum += count;
    count++;
}
Console.WriteLine(sum);

//======================================

int[] arr = {1, 4, -5, 83, 34, 67, 94, 100, 1};
int min = Int32.MaxValue;
int max = Int32.MinValue;
for(int i = 0; i < arr.Length; i++)
{
    if(min > arr[i])
        min = arr[i];
    if(max < arr[i])
        max = arr[i];
}
Console.WriteLine($"{min} x {max} = {min * max}");

//======================================================

System.Console.WriteLine("Enter a number");
int x = Convert.ToInt32(Console.ReadLine());
int start = 1;
int ans = 1;
while(start <= x)
{
    ans *= start;
    start++;
}
System.Console.WriteLine(ans);