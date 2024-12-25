using System;
using System.Globalization;

using Microsoft.Maui.Controls;

namespace TriviaStarQuizGame.Converters
{
    public class SelectedAnswerBorderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var answer = value as string;
            var selectedAnswer = parameter as string;

            // Log the values for debugging
            System.Diagnostics.Debug.WriteLine($"Convert called: answer={answer}, selectedAnswer={selectedAnswer}");

            // Return the appropriate color
            return answer == selectedAnswer ? Colors.Blue : Colors.Gray;
        }


        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
