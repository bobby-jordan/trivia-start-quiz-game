﻿using TriviaStarQuizGame.Views;

namespace TriviaStarQuizGame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
