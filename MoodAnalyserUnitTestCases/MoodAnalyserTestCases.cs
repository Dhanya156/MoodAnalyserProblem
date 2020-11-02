using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
using MoodAnalysis;
using System;
using System.Runtime.Serialization;

namespace MoodAnalyserUnitTestCases
{
    [TestClass]
    public class MoodAnalyserTestCases
    {
        /// <summary>TC  6.1 Given Happy Message Using Reflection When Proper Should Return HAPPY Mood.</summary>
        [TestMethod]
        public void Given_Happy_UsingReflection_When_Proper_Should_Return_HAPPYMood()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserReflector.InvokeAnalyseMood("AnalyseMood", "HAPPY");
            expected.Equals(obj);
        }

        /// <summary>TC 6.2 Given Happy Message When Improper Method Should Throw MoodAnalysisException.</summary>
        [TestMethod]
        public void Given_HappyMessage_When_Improper_MethodName_Should_Throw_MoodAnalysisException()
        {
            string expected = "HAPPY";
            try
            {
                object MoodAnalyserObject = MoodAnalyserReflector.InvokeAnalyseMood("DemoMethod", "HAPPY");
            }
            catch(AnalyserCustomExceptions e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}
