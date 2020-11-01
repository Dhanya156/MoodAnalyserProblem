using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;
using System;
using System.Runtime.Serialization;

namespace MoodAnalyserUnitTestCases
{
    [TestClass]
    public class MoodAnalyserTestCases
    {
        ///TC 3.1 Given null mood throw MoodAnalysis Exception 
        [TestMethod]
        public void Given_NULL_Mood_Should_throw_MoodAnalysisException()
        {
            try
            {
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch (AnalyserCustomExceptions e)
            {
                Assert.AreEqual("Mood should not be null", e.Message);
            }
        }


        ///TC 3.2 Given empty mood throw MoodAnalysis Exception 
        [TestMethod]
        public void Given_Empty_Mood_Should_throw_MoodAnalysisException()
        {
            try
            {
                string message = ""; 
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.AnalyseMood();
            }
            catch(AnalyserCustomExceptions e)
            {
                Assert.AreEqual("Mood should not be Empty", e.Message);
            }
        }
    }
}
