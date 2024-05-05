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
              
        // enter loop at 0 till 100 every time it loops +1 to number
        for (int number = 1; number <= 100; number++) 
        {


            //when number is divided by 5 buzz will output buzz and fizz will output blank
            if (number % 5 == 0 && number % 3 != 0) 
            {               
                output = "Buzz";
            }
            //when number is divided by 3 fizz will output fizz and buzz will out put blank
            if (number % 3 == 0 && number % 5 != 0)  
            {             
                output = "Fuzz";
            }
            //when divisible by both 3 and 5 output fizzbuzz
            if (number % 5 == 0 && number % 3 == 0) 
            {
                output = "FizzBuzz";
            }
            //when number is not divisible by 5 or 3 output the number
            if (number % 3 != 0 && number % 5 != 0) 
            {
                output = Convert.ToString(number);
            }

            //output the saved value for each string
            Console.WriteLine(output);

        }
        
    }
}