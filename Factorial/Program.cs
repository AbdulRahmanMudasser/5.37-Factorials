class Factorial
{
    static void Main()
    {
        // declaring variables
        int number, factorial = 1;

        // taking input from user
        Console.Write("Enter A Nonnegative Integer: ");
        number = Convert.ToInt32(Console.ReadLine());

        // check if the number is negative
        if (number < 0)
        {
            Console.WriteLine("Error: Negative Integer Entered.");
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
