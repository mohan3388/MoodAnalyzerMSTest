using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProgram;

namespace AnalyzerTest
{
    [TestClass]
    public class MoodAnalyze
    {
        private readonly MoodAnalyzer moodAnalyzer;
        public MoodAnalyze()
        {
            moodAnalyzer = new MoodAnalyzer("");
        }
        [TestMethod]
        [DataRow("", "message is Empty")]
        [DataRow(null, "message is null")]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Null(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Null");
            }
        }
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_EmptyMessage(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "Message is Empty");
            }

        }
    }
}