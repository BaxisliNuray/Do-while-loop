
Console.WriteLine("enter number from 10 to 20");

string num = Console.ReadLine();
int numbers = int.Parse(num);



do
{
    Console.WriteLine("want to continue?");
    Console.ReadLine();
    string yes = Console.ReadLine();
    if (numbers % 2 == 0)
    {
        Console.WriteLine("Even number");

    }
    else if (numbers % 2 == 1)
    {
        Console.WriteLine("Odd number");
    }

string no= Console.ReadLine();
break;
}while (!(numbers>10 && numbers<20));

















