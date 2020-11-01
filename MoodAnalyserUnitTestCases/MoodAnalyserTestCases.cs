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
        /// <summary>TC  5.1 Given the mood analyser class name should return mood analyser object.</summary>
        [TestMethod]
        public void Given_MoodAnalyserClassName_Should_Return_MoodAnalyser_Object()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
        }

        /// <summary>TC 5.2 Given the improper class name should throw mood analysis exception.</summary>
        [TestMethod]
        public void Given_Improper_ClassName_Should_Throw_MoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                object MoodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserProblem.DemoClass", "DemoClass", "Class Not Found");
            }
            catch(AnalyserCustomExceptions e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        /// <summary>TC 5.3 Given the class when constructor not proper should throw mood analysis exception.</summary>
        [TestMethod]
        public void Given_The_ClassWhen_ConstructorNotProper_Should_Throw_MoodAnalysisException()
        {
            string expected = "Constructor Not Found";
            try
            {
                object MoodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser", "Constructor Not Found");
            }
            catch (AnalyserCustomExceptions e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}
