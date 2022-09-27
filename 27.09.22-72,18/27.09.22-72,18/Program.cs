class Assgnment_18
{
    public static void Main()
    {
        Console.WriteLine("Program A");
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        if (num < 0)
            num = num * (-1);
        Console.WriteLine(num);

        Console.WriteLine("Program b");
        if (num < 0)
            num = num * (-1);
        else
            Console.WriteLine(num);
    }
}


//output:
//    num = 5  te number 5 in both of them.
//    The purpose of program A is to do an absolute value for every number that is less than zero.
//    The difference between the programs is that program B will not print a number that is less than zero.