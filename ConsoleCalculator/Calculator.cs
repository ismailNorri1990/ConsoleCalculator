﻿using System;
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
                catch (Exception)
                {

                    throw ;
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
