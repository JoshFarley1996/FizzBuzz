internal class Program
{
    private static void Main(string[] args)
    {
        // FizzBuzz:
        // 1) print out the numbers 1 to 100
        // 2) if the number is divisible by 3 print "Fizz" instead of the number
        // 3) if the number is divisible by 5 print "Buzz instead of the number
        // 4) if the number is divisible by both print both("FizzBuzz")
        // 5) if the number is divisible by 7 print Bizz instead of a number

 
     

        // enter loop at 0 till 100 every time it loops +1 to number
        for (int number = 1; number <= 100; number++)
        {
            //Reset the value of output for each instance of the loop
            string output = "";

            //Print Fizz when divisible by 3
            if (number % 3 == 0)
            {
                output += "Fizz";
            }

            //Print Buzz when divisible by 5
            if (number % 5 == 0)
            {
                output += "Buzz";
            }

            //Print Bizz when divisible by 7
            if (number % 7 == 0)
            {
                output += "Bizz";
            }

            //Print number when not divisible by 3 5 or 7
            if (output == "") 
            {
                output = Convert.ToString(number);
            }

            //output the saved value for each string
            Console.WriteLine(output);

        }
        
    }
}