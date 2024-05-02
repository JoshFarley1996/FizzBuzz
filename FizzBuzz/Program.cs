internal class Program
{
    private static void Main(string[] args)
    {
        string output = "";
        int number;

        for (number = 0; number <= 100; number++)
        {


            if (number % 5 == 0)
            {
                output = "Buzz";
            }
            if (number % 3 == 0)
            {
                output = "Fuzz";
            }
            if (number % 5 == 0 && number % 3 == 0)
            {
                output = "FizzBuzz";
            }
            if (number % 3 != 0 && number % 5 != 0)
            {
                output = Convert.ToString(number);
            }


            Console.WriteLine(output);

        }
        
    }
}