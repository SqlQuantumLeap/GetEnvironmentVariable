﻿/*
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
            Console.WriteLine("\nGetEnvironmentVariable");
            Console.Write("Version ");
            Console.WriteLine(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(3));
            Console.WriteLine("Copyright (c) 2015 Sql Quantum Leap. All rights reserved.\n");

            Console.WriteLine("Usage: GetEnvironmentVariable");
            Console.WriteLine("\t-name \"variable name\"");
            Console.WriteLine("\t[ -machine ]           (Default is to check User scoped variables)");
            Console.WriteLine("\t[ -? / -help ]         (Display this usage information)\n");

            Console.WriteLine("Notes:");
            Console.WriteLine("\tCommand-line option names are case-sensitive.");
            Console.WriteLine("\tEnvironment variable names are not case-sensitive.\n");

            Console.WriteLine("Visit http://SqlQuantumLeap.com for other useful utilities and more.");

            return;
        }
    
    }
}
