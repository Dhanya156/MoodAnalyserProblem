using MoodAnalyserProblem;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalysis
{
    /// <summary>
    /// MoodAnalyserReflector class is to create reflection of MoodAnalyser Class
    /// </summary>
    public class MoodAnalyserReflector
    {
        /// <summary>Creates the mood analyser.</summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructName">Name of the construct.</param>
        /// <exception cref="AnalyserCustomExceptions">Class not Found
        /// or
        /// Constructor Not Found</exception>
        public static object CreateMoodAnalyser(string className, string constructName)
        {
            string pattern = @"." + constructName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly excuting = Assembly.GetExecutingAssembly();

                    Type moodAnalyseType = excuting.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    throw new AnalyserCustomExceptions(AnalyserCustomExceptions.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
                }
            }
            else
            {
                throw new AnalyserCustomExceptions(AnalyserCustomExceptions.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");

            }

        }
        
        public static string InvokeAnalyseMood(string method, string message)
        {
            try
            {
                Type moodAnalyserType = typeof(MoodAnalyser);
                object moodAnalyserInstance = Activator.CreateInstance(moodAnalyserType);
                MethodInfo toInvoke = moodAnalyserType.GetMethod("AnalyseMood");
                toInvoke.Invoke(moodAnalyserInstance, null);
                return toInvoke.ToString();
            }
            catch (NullReferenceException)
            {
                throw new AnalyserCustomExceptions(AnalyserCustomExceptions.ExceptionType.NO_SUCH_METHOD, "No Such Method");
            }
          
        }

        internal static void CreateMoodAnalyser()
        {
            throw new NotImplementedException();
        }
    }
}

