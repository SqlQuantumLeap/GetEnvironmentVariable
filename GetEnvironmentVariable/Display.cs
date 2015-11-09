/*
 * "Get Environment Variable"
 * Copyright (c) 2015 Sql Quantum Leap. All rights reserved.
 * 
 */
using System;

namespace GetEnvironmentVariable
{
    internal class Display
    {
        internal static void Error(string ErrorMessage)
        {
            Console.Beep();

            Console.Error.Write("\n\tERROR: ");
            Console.Error.WriteLine(ErrorMessage.Replace("\n", "\n\t") + "\n");

            return;
        }

        internal static void Usage()
        {
            return;
        }
    
    }
}
