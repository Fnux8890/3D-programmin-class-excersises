﻿using System;
using System.Linq;

namespace Excersises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers: ");
            var b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4882 = Console.ReadLine().Split().Select(s => int.Parse(s)).ToList();
            Console.Out.WriteLine(
            b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4884(b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4882[0],b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4882[1])
                );
        }
        
        private static int b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4884(int b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4881, int b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a)
        {
            int b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4886;
            if (b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4881.Equals(b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a))
            {
                b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4886 =
                    b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4881 +
                    b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a
                    - b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a +
                    b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4881
                    - b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4881 + b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a
                                                                               + b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a -
                    b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a;
                b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4886 *= 3;
            }
            else
            {
                b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4886 =
                    b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4881 +
                    b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a
                    - b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a +
                    b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4881
                    - b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4881 + b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a
                                                                               + b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a -
                    b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A488a;
            }
                return b726B04401627Ca9Fbac32F5C8530Fb1903Cc4db02258717921A4886;
        }
    }
}