for(var i = 1; i <= 30; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.Write("FIZZBUZZ");
    }
    else if (i % 3 == 0 && i % 5 != 0)
    {
        Console.Write("FIZZ");
    }
    else if (i % 5 == 0 && i % 3 != 0)
    {
        Console.Write("BUZZ");
    }
    else
    {
        Console.Write(i);
    }
}
Console.WriteLine("");
var useNumStr = "";
int myNum;
Console.WriteLine("Please enter a whole number");
useNumStr = Console.ReadLine();
myNum = Convert.ToInt32(useNumStr);

for (int i = 1; i <= myNum; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.Write("FIZZBUZZ");
    }
    else if (i % 3 == 0 && i % 5 != 0)
    {
        Console.Write("FIZZ");
    }
    else if (i % 5 == 0 && i % 3 != 0)
    {
        Console.Write("BUZZ");
    }
    else
    {
        Console.Write(i);
    }
}    
