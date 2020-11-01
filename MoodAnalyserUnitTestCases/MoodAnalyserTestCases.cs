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
        /// <summary>TC  4.1 Given the mood analyser class name should return mood analyser object.</summary>
        [TestMethod]
        public void Given_MoodAnalyserClassName_Should_Return_MoodAnalyser_Object()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>TC 4.2 Given the improper class name should throw mood analysis exception.</summary>
        [TestMethod]
        public void Given_Improper_ClassName_Should_Throw_MoodAnalysisException()
        {
            string expected = "Class Not Found";
            try
            {
                object MoodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProblem.DemoClass", "DemoClass");
            }
            catch(AnalyserCustomExceptions e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        /// <summary>TC 4.3 Given the class when constructor not proper should throw mood analysis exception.</summary>
        [TestMethod]
        public void Given_The_ClassWhen_ConstructorNotProper_Should_Throw_MoodAnalysisException()
        {
            string expected = "Constructor Not Found";
            try
            {
                object MoodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyserProblem.MoodAnalyser(int id)", "MoodAnalyser(int id)");
            }
            catch (AnalyserCustomExceptions e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }
    }
}
