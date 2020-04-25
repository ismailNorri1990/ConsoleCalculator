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

            //When Filter the exception to throw
            catch (ArgumentNullException ex) when (ex.ParamName == "operation")
            {
                //Log.Error(ex);
                Console.WriteLine($"This is {ex}");
            }

            catch (ArgumentOutOfRangeException ex)
            {
                //Log.Error(ex);
                Console.WriteLine($"This is {ex}");
            }

            catch (Exception ex)
            {

                Console.WriteLine($"This is {ex}");
            }

            finally
            {
                Console.WriteLine("----Finaly-----");
            }

            

            Console.ReadLine();
        }
    }
}
