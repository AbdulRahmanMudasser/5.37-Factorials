class Factorial
{
    static void Main()
    {
        int number, factorial = 1;

        Console.Write("Enter a nonnegative integer: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.WriteLine("Error: Negative integer entered.");
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
    // end of main method
}
// end of class
