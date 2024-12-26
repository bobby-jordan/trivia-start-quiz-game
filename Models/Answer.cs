using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Answer : INotifyPropertyChanged
{
    private bool isSelected;

    public string Text { get; set; }
    public bool IsCorrect { get; set; }

    public bool IsSelected
    {
        get => isSelected;
        set
        {
            if (isSelected != value)
            {
                isSelected = value;
                OnPropertyChanged(nameof(IsSelected));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
