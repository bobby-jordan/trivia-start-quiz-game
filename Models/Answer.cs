using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Answer : INotifyPropertyChanged
{
    private bool isSelected;

    public string Text { get; set; } // The text of the answer
    public bool IsCorrect { get; set; } // Indicates if this is the correct answer
    public bool IsSelected
    {
        get => isSelected;
        set
        {
            if (isSelected != value)
            {
                isSelected = value;
                OnPropertyChanged();
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
