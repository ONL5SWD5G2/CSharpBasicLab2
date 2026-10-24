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

//Console.Write("month number: ");
//int month = int.Parse(Console.ReadLine()!);

//switch (month)
//{
//    case 1:
//    case 3:
//    case 5:
//    case 7:
//    case 8:
//    case 10:
//    case 12:
//        Console.WriteLine("31");
//        break;
//    case 4:
//    case 6:
//    case 9:
//    case 11:
//        Console.WriteLine("30");
//        break;
//    case 2:
//        Console.WriteLine("28");
//        break;
//    default:
//        Console.WriteLine("invalid month");
//        break;
//}

#endregion

#endregion

#region part2

#region 9
//Console.Write("Enter a number: ");
//int num9 = int.Parse(Console.ReadLine()!);

//for (int i = 1; i <= num9; i++)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();
#endregion

#region 10
//Console.Write("Enter a number: ");
//int num10 = int.Parse(Console.ReadLine()!);

//for (int i = 1; i <= 12; i++)
//{
//    Console.Write((num10 * i) + " ");
//}
//Console.WriteLine();
#endregion

#region 11
//Console.Write("Enter a number: ");
//int num11 = int.Parse(Console.ReadLine()!);

//for (int i = 2; i <= num11; i += 2)
//{
//    Console.Write(i + " ");
//}
//Console.WriteLine();
#endregion

#region 12
//Console.Write("Enter base number: ");
//int baseNum = int.Parse(Console.ReadLine()!);

//Console.Write("Enter exponent: ");
//int exp = int.Parse(Console.ReadLine()!);

//int result12 = 1;
//for (int i = 1; i <= exp; i++)
//{
//    result12 = result12 * baseNum;
//}
//Console.WriteLine("Output: " + result12);
#endregion

#region 13
//Console.Write("Enter an integer: ");
//int num13 = int.Parse(Console.ReadLine()!);

//int reversed = 0;
//while (num13 > 0)
//{
//    int remainder = num13 % 10;
//    reversed = (reversed * 10) + remainder;
//    num13 = num13 / 10;
//}
//Console.WriteLine("Output: " + reversed);
#endregion

#region 14
//Console.Write("Input starting number: ");
//int start = int.Parse(Console.ReadLine()!);

//Console.Write("Input ending number: ");
//int end = int.Parse(Console.ReadLine()!);

//Console.Write("The prime numbers are: ");
//for (int i = start; i <= end; i++)
//{
//    if (i < 2) continue;

//    bool isPrime = true;
//    for (int j = 2; j < i; j++)
//    {
//        if (i % j == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if (isPrime)
//    {
//        Console.Write(i + " ");
//    }
//}
//Console.WriteLine();
#endregion

#region 15
//Console.Write("Enter x1: ");
//int x1 = int.Parse(Console.ReadLine()!);
//Console.Write("Enter y1: ");
//int y1 = int.Parse(Console.ReadLine()!);

//Console.Write("Enter x2: ");
//int x2 = int.Parse(Console.ReadLine()!);
//Console.Write("Enter y2: ");
//int y2 = int.Parse(Console.ReadLine()!);

//Console.Write("Enter x3: ");
//int x3 = int.Parse(Console.ReadLine()!);
//Console.Write("Enter y3: ");
//int y3 = int.Parse(Console.ReadLine()!);

//if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
//{
//    Console.WriteLine("Points lie on a single straight line.");
//}
//else
//{
//    Console.WriteLine("Points do NOT lie on a single straight line.");
//}
#endregion

#region 16
Console.Write("Enter matrix size (n): ");
int n = int.Parse(Console.ReadLine()!);

for (int row = 0; row < n; row++)
{
    for (int col = 0; col < n; col++)
    {
        if (row == col)
        {
            Console.Write("1 ");
        }
        else
        {
            Console.Write("0 ");
        }
    }
    Console.WriteLine();
}
#endregion

#endregion
