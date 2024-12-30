using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaStarQuizGame.Converters
{
    public class AnswerBorderColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool showFeedback && showFeedback)
            {
                // Return green for correct, red for incorrect
                return parameter is bool isCorrect && isCorrect ? Colors.Green : Colors.Red;
            }
            return Colors.Transparent; // Default border color
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
