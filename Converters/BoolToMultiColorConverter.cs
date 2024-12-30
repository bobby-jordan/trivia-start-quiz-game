using System.Globalization;

namespace TriviaStarQuizGame.Converters
{
    public class BoolToMultiColorConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is bool isSelected && isSelected)
            {
                if (values[1] is bool isCorrect && isCorrect)
                {
                    return Colors.Green;
                }
                return Colors.MediumVioletRed;
            }
            return Colors.Transparent; 
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
