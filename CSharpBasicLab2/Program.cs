#region part1

#region 1

//Console.Write("enter a number: ");
//int userInput = int.Parse(Console.ReadLine() ?? "0");
//Console.WriteLine("the number is: " + userInput);

#endregion

#region 2

//double num1 = 0.1;
//double num2 = 0.2;
//double sum = num1 + num2;

//Console.WriteLine(sum);

#endregion

#region 3

//int x = 10;
//int y = x;

//x = 20;

//Console.WriteLine(x);
//Console.WriteLine(y);

#endregion

#region 4

//Console.Write("principal amount: ");
//double principal = double.Parse(Console.ReadLine() ?? "0");

//Console.Write("rate of interest: ");
//double rate = double.Parse(Console.ReadLine() ?? "0");

//Console.Write("time: ");
//double time = double.Parse(Console.ReadLine() ?? "0");

//double interest = (principal * rate * time) / 100;

//Console.WriteLine($"Simple Interest: {interest}");

#endregion

#region 5

//Console.Write("temperature: ");
//double temp = double.Parse(Console.ReadLine() ?? "0");

//string result = temp < 10 ? "Just Cold" : (temp > 30 ? "Just Hot" : "Just Good");

//Console.WriteLine(result);

#endregion

#region 6

//Console.Write("num: ");
//int number = int.Parse(Console.ReadLine() ?? "0");

//if (number % 3 == 0 && number % 4 == 0)
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}

#endregion

#region 7

//Console.Write("Enter first number: ");
//int a = int.Parse(Console.ReadLine()!);

//Console.Write("Enter second number: ");
//int b = int.Parse(Console.ReadLine()!);

//Console.Write("Enter third number: ");
//int c = int.Parse(Console.ReadLine()!);

//int max = Math.Max(a, Math.Max(b, c));
//int min = Math.Min(a, Math.Min(b, c));

//Console.WriteLine($"max element = {max}");
//Console.WriteLine($"min element = {min}");

#endregion

#region 8

Console.Write("month number: ");
int month = int.Parse(Console.ReadLine()!);

switch (month)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        Console.WriteLine("31");
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        Console.WriteLine("30");
        break;
    case 2:
        Console.WriteLine("28");
        break;
    default:
        Console.WriteLine("invalid month");
        break;
}

#endregion

#endregion
