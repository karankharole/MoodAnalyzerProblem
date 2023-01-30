﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer() { }
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                bool result1 = message.Contains("Happy", StringComparison.OrdinalIgnoreCase);

                if (result1)
                {
                    return "HAPPY";
                }
                else
                {
                    return "SAD";
                }
            }
            catch
            {
                return "HAPPY";
            }
        }

        internal void AnalyzeMood(string? mood)
        {
            throw new NotImplementedException();
        }
    }
}
