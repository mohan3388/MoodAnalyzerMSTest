using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProgram
{
    public class MoodAnalyzer
    {
        string message;
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }
        public string MoodAnalys()
        {
            if (message.ToLower().Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
            return message;
        }
    }
}
