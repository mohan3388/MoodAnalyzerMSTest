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
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Happy(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (System.Exception ex)
            {
                Assert.AreEqual(ex.Message, "message is Empty");
            }

        }
    }
}