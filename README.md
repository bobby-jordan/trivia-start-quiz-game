# Trivia Star Quiz Game

Trivia Star Quiz Game is a fun and interactive quiz game application built using .NET MAUI. It allows users to test their knowledge in various categories, track their scores, and view results in a user-friendly interface.

## Features

- **Multiple Categories**: Choose from categories like Science, History, Entertainment, Politics, Geography, and more.
- **Dynamic Questions**: Each category has its own unique set of questions.
- **Score Tracking**: Keeps track of the correct answers and displays the score at the end of the quiz.
- **Interactive UI**: Responsive design with dynamically generated buttons and real-time answer selection feedback.
- **Final Results**: Displays a summary of the user's performance at the end of the game.

## Technologies Used

- **Framework**: .NET MAUI
- **Programming Language**: C#
- **MVVM Architecture**: Ensures clean separation of UI and business logic.
- **Git Integration**: Version control with Git.

## Getting Started

### Prerequisites

- Install [.NET SDK](https://dotnet.microsoft.com/) (version 8 or later).
- Install Visual Studio with .NET MAUI workloads enabled.

### Clone the Repository

```bash
git clone https://github.com/bobby-jordan/trivia-start-quiz-game.git
cd trivia-start-quiz-game
```

### Run the Project

1. Open the solution file (`TriviaStarQuizGame.sln`) in Visual Studio.
2. Build the project to restore dependencies.
3. Select the target platform (e.g., Android, iOS, Windows).
4. Run the project.

## How to Play

1. **Choose a Category**: Select a category from the list on the home page.
2. **Answer Questions**: Select the correct answer for each question. The border of the selected answer changes color to indicate selection.
3. **Submit Answers**: Click the "Submit Answer" button to move to the next question.
4. **View Results**: After completing the quiz, view your score on the final results page.

## Project Structure

- **Models**: Contains `Question` and `Answer` classes for quiz data.
- **ViewModels**: Implements MVVM logic, including score tracking and dynamic question loading.
- **Views**: Contains XAML pages for UI, such as the category selection, question page, and final results page.
- **Converters**: Includes `BoolToColorConverter` for UI feedback based on answer selection.

## Key Features in Code

- **Dynamic Questions**: Questions are categorized and loaded dynamically based on user selection.
- **Enum-based Categories**: Categories are managed using a `QuizCategory` enum.
- **Score Tracking**: Incremental score tracking displayed on the final results page.
- **Interactive Answer Selection**: Real-time visual feedback for selected answers.

## Contributing

Contributions are welcome! If you have ideas for new features or improvements, feel free to fork the repository and submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions or suggestions, please contact:
- **Name**: Bobby Jordan
- **Email**: [bobby.jordan@example.com](mailto:bobby.jordan@example.com)
- **GitHub**: [https://github.com/bobby-jordan](https://github.com/bobby-jordan)
