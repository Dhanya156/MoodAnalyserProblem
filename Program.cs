﻿using MoodAnalysis;
using System;

namespace MoodAnalyserProblem
{
    class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Problem");
            MoodAnalyserReflector.CreateMoodAnalyser();
        }
    }
}
