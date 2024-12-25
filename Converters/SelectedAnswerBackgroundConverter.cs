using System;
using System.Globalization;

using Microsoft.Maui.Controls;

namespace TriviaStarQuizGame.Converters
{
    public class SelectedAnswerBackgroundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var answer = value as string;
            var selectedAnswer = parameter as string;
            return answer == selectedAnswer ? Colors.LightBlue : Colors.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
