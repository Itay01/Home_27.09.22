class Assgnment_19
{
    public static void Main()
    {
        int digit, num, m;
        Console.WriteLine("Enter a digit:");
        digit = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a two digits number:");
        num = int.Parse(Console.ReadLine());
        m = 0;
        if (num / 10 == digit)
            m++;
        if (num % 10 == digit)
            m++;
        Console.WriteLine("m = {0}", m);
    }
}


//output:
//    digit = 5, num = 55 | m = 2.
//    digit = 3, num = 34 | m = 1.
//    e.x: m = 0 | digit = 1, num = 20.
//    The purpose of this program is to check if the digit is equal to:
//      1. The number divided by 10.
//      2. The left digit.