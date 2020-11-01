using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace MoodAnalyserUnitTestCases
{
    [TestClass]
    public class MoodAnalyserTestCases
    {
                /// <summary>Givens the message sad should return sad.</summary>
        /// <param name="message">The message.</param> 
        [TestMethod]
        public void Given_Message_sad_Should_Return_SAD()
        {
            ///Arrange
            string expected = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            ///Act
            string mood = moodAnalyser.AnalyseMood("sad");

            ///Assert
            Assert.AreEqual(expected, mood);

        }

        /// <summary>Givens the message happy should return happy.</summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        public void Given_Message_Happy_Should_Return_HAPPY()
        {
            ///Arrange
            string expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            ///Act
            string mood = moodAnalyser.AnalyseMood("Happy");

            ///Assert
            Assert.AreEqual(expected, mood);

        }

        /// <summary>TC 1.1 Given the message i am in sad mood should return sad.</summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        public void Given_Message_IAmInSadMood_Should_Return_SAD()
        {
            ///Arrange
            string expected = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            ///Act
            string mood = moodAnalyser.AnalyseMood("I am in sad Mood");

            ///Assert
            Assert.AreEqual(expected, mood);

        }

        /// <summary>TC 1.2 Given the message i am in happy mood should return happy.</summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        public void Given_Message_IAmInHappyMood_Should_Return_HAPPY()
        {
            ///Arrange
            string expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser();

            ///Act
            string mood = moodAnalyser.AnalyseMood("I am in Happy Mood");

            ///Assert
            Assert.AreEqual(expected, mood);

        }

        /// <summary>Refactored TC 1.1 Given the message i am in sad mood should return sad.</summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        public void Given_Message_INConstructor_IAmInSadMood_Should_Return_SAD()
        {
            ///Arrange
            string expected = "SAD";
            string message = "I am in sad Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            ///Act
            string mood = moodAnalyser.AnalyseMood();

            ///Assert
            Assert.AreEqual(expected, mood);

        }
        /// <summary>Refactored TC 1.2 Given the message i am in happy mood should return happy.</summary>
        /// <param name="message">The message.</param>
        [TestMethod]
        public void Given_Message_InConstructor_IAmInHappyMood_Should_Return_HAPPY()
        {
            ///Arrange
            string expected = "HAPPY";
            string message = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);

            ///Act
            string mood = moodAnalyser.AnalyseMood();

            ///Assert
            Assert.AreEqual(expected, mood);

        }
    }
}
