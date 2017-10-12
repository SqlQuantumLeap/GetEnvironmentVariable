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
	internal class InputParameters
	{
        /* Environment.GetEnvironmentVariable (String, EnvironmentVariableTarget) ( https://msdn.microsoft.com/en-us/library/y6k3c7b0.aspx )
         * 
         * -name "Variable Name" (required)
         * -machine use Machine scope
         * -? / -help  Display usage
         */

        private string _VariableName = String.Empty;
        internal string VariableName
		{
			get
			{
                return this._VariableName;
			}
		}

        private EnvironmentVariableTarget _VariableScope = EnvironmentVariableTarget.User;
        internal EnvironmentVariableTarget VariableScope
        {
            get
            {
                return this._VariableScope;
            }
        }

		private bool _DisplayUsage = false;
		internal bool DisplayUsage
		{
			get
			{
				return this._DisplayUsage;
			}
		}


        public InputParameters(string[] args)
		{
            if (args.Length == 0)
            {
                _DisplayUsage = true;

                return;
            }

			for (int _Index = 0; _Index < args.Length; _Index++)
			{
				switch (args[_Index])
				{
					case "-name":
					case "/name":
						this._VariableName = args[++_Index];
						break;
					case "-machine":
					case "/machine":
                        this._VariableScope = EnvironmentVariableTarget.Machine;
						break;
                    case "-help":
					case "-?":
					case "/help":
					case "/?":
						this._DisplayUsage = true;
						break;
					default:
						throw new ArgumentException("Invalid parameter specified.", args[_Index]);
				}
			}

            if (!this.DisplayUsage && this.VariableName == String.Empty)
            {
                throw new ArgumentNullException("-name", "You must specify an Environment Variable Name!");
            }
		}


	}
}
