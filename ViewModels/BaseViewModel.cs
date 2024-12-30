using System.ComponentModel;
using System.Runtime.CompilerServices;

using TriviaStarQuizGame.Enums;
using TriviaStarQuizGame.State;

namespace TriviaStarQuizGame.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public QuizState State => QuizState.Instance;

        public QuizCategory? CurrentCategory
        {
            get => State.CurrentCategory;
            set
            {
                if (State.CurrentCategory != value)
                {
                    State.CurrentCategory = value;
                    OnPropertyChanged(nameof(CurrentCategory));
                }
            }
        }

        public string PlayerName
        {
            get => State.PlayerName;
            set
            {
                if (State.PlayerName != value)
                {
                    State.PlayerName = value;
                    OnPropertyChanged(nameof(PlayerName));
                }
            }
        }

        public int Score
        {
            get => State.Score;
            set
            {
                if (State.Score != value)
                {
                    State.Score = value;
                    OnPropertyChanged(nameof(Score));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
