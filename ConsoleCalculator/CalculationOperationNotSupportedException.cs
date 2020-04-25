using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCalculator
{
    public class CalculationOperationNotSupportedException : CalculationException
    {
        public  string Operation { get; }
        
        /// <summary>
        /// 
        /// </summary>
        public CalculationOperationNotSupportedException() : base("Specified operation is pout of the range")
        {
                
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="operation"></param>
        public CalculationOperationNotSupportedException(string operation) : this()
        {
            Operation = operation;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public CalculationOperationNotSupportedException(string message, Exception innerException) : base(message,innerException)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="operation"></param>
        /// <param name="message"></param>
        public CalculationOperationNotSupportedException(string operation ,string message) : base(message)
        {
            Operation = operation;
        }

        public override string Message
        {
            get
            {
               string message = base.Message;

                if(Operation != null)
                {
                    return message + Environment.NewLine + $"Unsuported operation {Operation}";
                } 
                else
                {
                    return message;
                }
            }
        }



    }
}
