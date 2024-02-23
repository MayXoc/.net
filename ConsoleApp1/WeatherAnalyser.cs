using System;
using System.Linq;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class WeatherDataAnalyzer
    {
        public (int Day, int TempRange, bool IsUnusual)? Analyze(List<(int Day, int MinTemp, int MaxTemp)> weatherData)
        {
            // Using LINQ to easily parse through the list of weather data. (Lesson: LINQ Introduction)
            return weatherData
                .Select(data => data switch
                {
                    // Using pattern matching to analyze weather data, swings in temperature. (Lesson: Pattern Matching - Part 1 and 2)
                    (var day, var minTemp, var maxTemp) when minTemp <= maxTemp && maxTemp - minTemp > 15 => (Day: day, TempRange: maxTemp - minTemp, IsUnusual: true),

                    (var day, var minTemp, var maxTemp) when minTemp <= maxTemp => (Day: day, TempRange: maxTemp - minTemp, IsUnusual: false),

                    _ => (Day: 0, TempRange: 0, IsUnusual: false)
                })
                .OrderByDescending(data => data.TempRange)
                .FirstOrDefault(data => data.TempRange != 0);
        }
    }
}