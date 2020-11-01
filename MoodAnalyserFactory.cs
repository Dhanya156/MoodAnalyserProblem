using MoodAnalyserProblem;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalysis
{
    /// <summary>
    /// MoodAnalyserFactory class is to create reflection of MoodAnalyser Class
    /// </summary>
    public class MoodAnalyserFactory
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
        /// <summary>Creates the mood analyser using parameterized constructor.</summary>
        /// <param name="className">Name of the class.</param>
        /// <param name="constructorName">Name of the constructor.</param>
        /// <param name="message">The message.</param>
        /// <exception cref="AnalyserCustomExceptions">Constructor not Found
        /// or
        /// Class not Found</exception>
        public static object CreateMoodAnalyserUsingParameterizedConstructor(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new AnalyserCustomExceptions(AnalyserCustomExceptions.ExceptionType.NO_SUCH_METHOD, "Constructor Not Found");
                }
            }
            else
            {
                throw new AnalyserCustomExceptions(AnalyserCustomExceptions.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
        }

        internal static void CreateMoodAnalyser()
        {
            throw new NotImplementedException();
        }
    }
}

