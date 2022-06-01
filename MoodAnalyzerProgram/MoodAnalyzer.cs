using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class MoodAnalyzer
    {
        public string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {

                if (message.ToLower().Contains("HAPPY"))
                {
                    return "HAPPY";
                }
                else
                {
                    return "SAD";
                }
            }
            catch (Exception)
            {
                return "HAPPY";
            }

        }
    }
}
