using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    /// <summary>
    ///MoodAnalyser class is created to Analyse the Mood
    /// </summary>
    public class MoodAnalyser
    {
        /// <summary>The message</summary>
        private string message;
        /// <summary>Initializes a new instance of the <see cref="MoodAnalyser" /> class.</summary>
        public MoodAnalyser()
        {

        }

        /// <summary>Initializes a new instance of the <see cref="MoodAnalyser" /> class.</summary>
        /// <param name="message">The message.</param>
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        /// <summary>Analyses the mood.</summary>
        /// <param name="message">The message.</param>
        /// <returns>
        ///AnalyseMood Is a method that returns Happy or Sad
        /// </returns>
        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch
            {
                return "HAPPY";
            }
        }

        public string AnalyseMood(string message)
        {
            throw new NotImplementedException();
        }
    }
}
