using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem
{
    public class AnalyserCustomExceptions : Exception
    {
        /// <summary>
        /// Enum for Exception Typr
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_FEILD, NO_SUCH_CLASS,
            NO_METHOD, OBJECT_CREATION_ISSUE
        }

        /// <summary>Creation type variable of type ExceptionType</summary>
        private readonly ExceptionType type;

        /// <summary>Initializes a new instance of the <see cref="AnalyserCustomExceptions" /> class.</summary>
        /// <param name="Type">The type.</param>
        /// <param name="message">The message.</param>
        public AnalyserCustomExceptions(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
