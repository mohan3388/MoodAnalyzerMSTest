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
        [DataRow(" ", "Message is Empty")]
        [DataRow(null, "Message is Null")]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Null(string input, string expected)
        {
            try
            {
                var result = moodAnalyzer.AnalyzeMood();
            }
            catch (MoodAnalyzerException ex)
            {
                Assert.AreEqual(ex.Message, "message is Null");
            }
        }
        
        public void MoodAnalysereturnEmpty(string input, string expected)
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
        [TestMethod]
        public void GivenMoodAnalysisClassName_ShouldReturnMoodAnalysisObject()
        {
            object expected = new MoodAnalyzer();
            object obj = AnalyzeFactory.CreateMoodAnalysis("MoodAnalyzerProgram.MoodAnalyzer", "MoodAnalyzer");
            expected.Equals(obj);
        }
    }
}