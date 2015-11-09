/*
 * "Get Environment Variable"
 * Copyright (c) 2015 Sql Quantum Leap. All rights reserved.
 * 
 */
using System;

namespace GetEnvironmentVariable
{
    class Program
    {
        static int Main(string[] args)
        {
            InputParameters _InputParams;

            Console.Title = "Get Environment Variable (from Sql Quantum Leap -- http://SqlQuantumLeap.com/)";

            try
            {
                _InputParams = new InputParameters(args);
            }
            catch (ArgumentException _ArgException)
            {
                Display.Error(_ArgException.Message + " (" + _ArgException.ParamName + ")");

                return 1;
            }
            catch (Exception _Exception)
            {
                Display.Error(_Exception.Message);

                return 2;
            }

            if (_InputParams.DisplayUsage)
            {
                Display.Usage();

                return 0;
            }


            Console.Out.Write(Environment.GetEnvironmentVariable(_InputParams.VariableName, _InputParams.VariableScope));

            return 0;
        }
    }
}
