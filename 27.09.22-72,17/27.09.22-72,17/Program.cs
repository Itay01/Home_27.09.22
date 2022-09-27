class Assignment_17
{
    public static void Main()
    {
        double a, b, temp;
        Console.WriteLine("Enter the value of a:");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of b:");
        b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        Console.WriteLine("a = {0}, b = {1}", a, b);
    }
}

// output:
//    a = 1, b = 2  same.
//    a = 2, b = 1  switch.
//    a = 1, b = 1  same.
// 56 / 5,000
// The purpose of this program is to switch the variables a and b if a is greater than b.
