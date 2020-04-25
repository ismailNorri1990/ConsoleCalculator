using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class CalculationException : Exception
    {
        private static readonly string DefaultMessage = "This is my custom exception message ! ";
        /// <summary>
        /// 
        /// </summary>
        public CalculationException() : base(DefaultMessage)
        {
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public CalculationException(string message) : base(message)
        {
                
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="InnerException"></param>
        public CalculationException(Exception InnerException): base(DefaultMessage,InnerException)
        {
        }

        public CalculationException(string message ,Exception InnerException) : base(message, InnerException)
        {
        }
    }
}
