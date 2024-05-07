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

 
        string output = "";
        string buzz = "";
        string fizz = "";
        string bizz = "";


        // enter loop at 0 till 100 every time it loops +1 to number
        for (int number = 1; number <= 100; number++)
        {
            //Make 3 different if else statements to print Fuzz Buzz Bizz when the give number is divisible by 3 5 7
                        
            //Print Fizz when divisible by 3
            if (number % 3 == 0)
            {
                fizz = "Fizz";
            }
            else
            {
                fizz = "";
            }

            //Print Buzz when divisible by 5
            if (number % 5 == 0)
            {
                buzz = "Buzz";
            }
            else
            {
                buzz = "";
            }

            //Print Bizz when divisible by 7
            if (number % 7 == 0)
            {
                bizz = "Bizz";
            }
            else
            {
                bizz = "";
            }

            //Print number when not divisible by 3 5 or 7
            if (number % 3 != 0 && number % 5 != 0 && number % 7 !=0) 
            {
                output = Convert.ToString(number);
            }
            else
            {
                output = "";
            }

            //output the saved value for each string
            Console.WriteLine($"{fizz}{buzz}{bizz}{output}");

        }
        
    }
}