using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserUnitTestCases
{
    [TestClass]
    public class MoodAnalyserTestCases
    {
        [TestMethod]
        [DataRow(null)]
        ///TC 2.1 Given message Null should Return Happy 
        /// <param name="message">The message.</param>
        public void Given_Message_NULL_Should_Return_HAPPY(string message)
        {
            ///Arrange
            string expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            ///Act
            string mood = moodAnalyser.AnalyseMood();

            ///Assert
            Assert.AreEqual(expected, mood);

        }
    }
}
