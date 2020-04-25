using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int val1, int val2, string operation)
        {
            //if(operation == null)
            //{
            //    throw new NullReferenceException("operation");
            //}

            string nonNullOperation = operation ?? throw new ArgumentNullException(nameof(operation));


            if (nonNullOperation == "/")
            {
                try
                {
                return Divide(val1, val2);

                }

                catch (Exception ex)
                {
                    //Retrowing exeption and preserving stack trace
                    //throw;


                    //Wrapping exception in More general Type of exception
                 throw new ArithmeticException("An Error occured during calculation",ex);
                }
                
            }
            else
            {
                throw new ArgumentOutOfRangeException("operation","Non recognized operations");
            }
        }

        private int Divide(int val1, int val2)
        {
            return val1/val2 ;
        }
    }
}
