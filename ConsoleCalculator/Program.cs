using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var divide = new Calculator();

            var input1 = int.Parse(Console.ReadLine());
            
            var input2 = int.Parse(Console.ReadLine());
            var operation = Console.ReadLine();

            try
            {
                var result = divide.Calculate(input1, input2, null);
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine($"This is {ex}");
            }
            


            

            Console.ReadLine();
        }
    }
}
