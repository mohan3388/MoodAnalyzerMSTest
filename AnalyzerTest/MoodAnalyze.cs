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
            moodAnalyzer = new MoodAnalyzer("I am in Happy Mood");
        }
        [TestMethod]
        public void InputInString_CheckingMoodAnalysis_MustBeReturn_Happy()
        {
            var result = moodAnalyzer.MoodAnalys();
            Assert.AreEqual(result, "HAPPY");
        }
    }
}