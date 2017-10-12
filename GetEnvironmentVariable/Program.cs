/*
 * "Get Environment Variable"
 * Copyright (c) 2015 Solomon Rutzky. All rights reserved.
 * 
 * https://github.com/SqlQuantumLeap/GetEnvironmentVariable
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

            Console.Title = "Get Environment Variable (from Solomon Rutzky -- https://SqlQuantumLeap.com/)";

            try
            {
                _InputParams = new InputParameters(args);
            }
            catch (ArgumentException _ArgException)
            {
                Display.Error(_ArgException.Message);

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


            Console.Out.Write(Environment.GetEnvironmentVariable(
                _InputParams.VariableName, _InputParams.VariableScope));

            return 0;
        }
    }
}
