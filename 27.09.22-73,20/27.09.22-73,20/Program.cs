class Assgnment_20
{
    public static void Main()
    {
        int num, max, t;
        Console.WriteLine("Enter a three digits number:");
        num = int.Parse(Console.ReadLine());
        max = num % 10;
        t = num / 10 % 10;
        if (t > max)
            max = t;
        t = num / 100;
        if (t > max)
            max = t;
        Console.WriteLine("the digit is {0}", max);
    }
}


//output:
//    num = 692 | max = 9.
//    num = 811 | max = 8.
//    e.x: max = 9 | num = 592.
//    The purpose this program is to find the largest digit in the number.