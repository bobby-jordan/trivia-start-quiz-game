using TriviaStarQuizGame.Enums;
using TriviaStarQuizGame.Models;

namespace TriviaStarQuizGame.Utilities
{
    public class QuestionProvider
    {
        public List<Question> GetQuestions(QuizCategory category)
        {
            return category switch
            {
                QuizCategory.Science =>
                [
                    new Question
                    {
                        Text = "What is the chemical symbol for water?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "H2O", IsCorrect = true },
                            new() { Text = "O2", IsCorrect = false },
                            new() { Text = "CO2", IsCorrect = false },
                            new() { Text = "NaCl", IsCorrect = false }
                        ],
                        QuestionImage = "water.jpg"
                    },
                    new Question
                    {
                        Text = "What planet is known as the Red Planet?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Mars", IsCorrect = true },
                            new() { Text = "Venus", IsCorrect = false },
                            new() { Text = "Jupiter", IsCorrect = false },
                            new() { Text = "Mercury", IsCorrect = false }
                        ],
                        QuestionImage = "mars.jpg"
                    },
                    new Question
                    {
                        Text = "What is the hardest natural substance on Earth?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Diamond", IsCorrect = true },
                            new() { Text = "Gold", IsCorrect = false },
                            new() { Text = "Iron", IsCorrect = false },
                            new() { Text = "Platinum", IsCorrect = false }
                        ],
                        QuestionImage = "diamond.jpg"
                    },
                    new Question
                    {
                        Text = "What is the primary gas found in Earth's atmosphere?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Nitrogen", IsCorrect = true },
                            new() { Text = "Oxygen", IsCorrect = false },
                            new() { Text = "Carbon Dioxide", IsCorrect = false },
                            new() { Text = "Hydrogen", IsCorrect = false }
                        ],
                        QuestionImage = "atmosphere.jpg"
                    },
                    new Question
                    {
                        Text = "What is the process by which plants make their own food?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Photosynthesis", IsCorrect = true },
                            new() { Text = "Respiration", IsCorrect = false },
                            new() { Text = "Digestion", IsCorrect = false },
                            new() { Text = "Fermentation", IsCorrect = false }
                        ],
                        QuestionImage = "photosynthesis.jpg"
                    }
                ],
                QuizCategory.Art =>
                [
                    new Question
                    {
                        Text = "Who painted the Mona Lisa?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Leonardo da Vinci", IsCorrect = true },
                            new() { Text = "Pablo Picasso", IsCorrect = false },
                            new() { Text = "Vincent van Gogh", IsCorrect = false },
                            new() { Text = "Claude Monet", IsCorrect = false }
                        ],
                         QuestionImage = "mona_lisa.jpg"
                    },
                    new Question
                    {
                        Text = "What art movement is Salvador Dalí associated with?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Surrealism", IsCorrect = true },
                            new() { Text = "Cubism", IsCorrect = false },
                            new() { Text = "Impressionism", IsCorrect = false },
                            new() { Text = "Realism", IsCorrect = false }
                        ],
                        QuestionImage = "salvador_dali.jpg"
                    },
                    new Question
                    {
                        Text = "The Starry Night was painted by which artist?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Vincent van Gogh", IsCorrect = true },
                            new() { Text = "Claude Monet", IsCorrect = false },
                            new() { Text = "Edgar Degas", IsCorrect = false },
                            new() { Text = "Paul Cézanne", IsCorrect = false }
                        ],
                        QuestionImage = "starry_night.jpg"
                    },
                    new Question
                    {
                        Text = "Which famous sculpture was created by Michelangelo?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "David", IsCorrect = true },
                            new() { Text = "The Thinker", IsCorrect = false },
                            new() { Text = "Venus de Milo", IsCorrect = false },
                            new() { Text = "Apollo Belvedere", IsCorrect = false }
                        ],
                        QuestionImage = "michelangelo.jpg"
                    },
                    new Question
                    {
                        Text = "What is the art technique of using light and shadow to create depth?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Chiaroscuro", IsCorrect = true },
                            new() { Text = "Fresco", IsCorrect = false },
                            new() { Text = "Pointillism", IsCorrect = false },
                            new() { Text = "Sfumato", IsCorrect = false }
                        ],
                        QuestionImage = "shadows.jpg"
                    }
                ],
                QuizCategory.Culture =>
                [
                    new Question
                    {
                        Text = "What is the traditional dress of Japan called?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Kimono", IsCorrect = true },
                            new() { Text = "Hanbok", IsCorrect = false },
                            new() { Text = "Sari", IsCorrect = false },
                            new() { Text = "Cheongsam", IsCorrect = false }
                        ],
                        QuestionImage = "dress.jpg"
                    },
                    new Question
                    {
                        Text = "Which country is famous for its flamenco dance?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Spain", IsCorrect = true },
                            new() { Text = "France", IsCorrect = false },
                            new() { Text = "Italy", IsCorrect = false },
                            new() { Text = "Portugal", IsCorrect = false }
                        ],
                        QuestionImage = "flamenco.jpg"
                    },
                    new Question
                    {
                        Text = "Diwali is a festival celebrated in which country?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "India", IsCorrect = true },
                            new() { Text = "Nepal", IsCorrect = false },
                            new() { Text = "Sri Lanka", IsCorrect = false },
                            new() { Text = "Bangladesh", IsCorrect = false }
                        ],
                        QuestionImage = "candle.jpg"
                    },
                    new Question
                    {
                        Text = "What is the name of the Maori traditional dance?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Haka", IsCorrect = true },
                            new() { Text = "Samba", IsCorrect = false },
                            new() { Text = "Tango", IsCorrect = false },
                            new() { Text = "Limbo", IsCorrect = false }
                        ],
                        QuestionImage = "dance.jpg"
                    },
                    new Question
                    {
                        Text = "Which African country is known for its Maasai tribe?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Kenya", IsCorrect = true },
                            new() { Text = "South Africa", IsCorrect = false },
                            new() { Text = "Nigeria", IsCorrect = false },
                            new() { Text = "Ethiopia", IsCorrect = false }
                        ],
                        QuestionImage = "tribe.jpg"
                    }
                ],
                QuizCategory.Technology =>
                [
                    new Question
                    {
                        Text = "Who is known as the father of computers?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Charles Babbage", IsCorrect = true },
                            new() { Text = "Alan Turing", IsCorrect = false },
                            new() { Text = "John von Neumann", IsCorrect = false },
                            new() { Text = "Steve Jobs", IsCorrect = false }
                        ],
                        QuestionImage = "computer.jpg"
                    },
                    new Question
                    {
                        Text = "What does CPU stand for?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Central Processing Unit", IsCorrect = true },
                            new() { Text = "Computer Processing Unit", IsCorrect = false },
                            new() { Text = "Central Programming Unit", IsCorrect = false },
                            new() { Text = "Core Processing Unit", IsCorrect = false }
                        ],
                        QuestionImage = "cpu.jpg"
                    },
                    new Question
                    {
                        Text = "Which company developed the Windows operating system?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Microsoft", IsCorrect = true },
                            new() { Text = "Apple", IsCorrect = false },
                            new() { Text = "IBM", IsCorrect = false },
                            new() { Text = "Google", IsCorrect = false }
                        ],
                        QuestionImage = "windows.jpg"
                    },
                    new Question
                    {
                        Text = "What programming language is primarily used for Android app development?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Java", IsCorrect = true },
                            new() { Text = "Swift", IsCorrect = false },
                            new() { Text = "Python", IsCorrect = false },
                            new() { Text = "C#", IsCorrect = false }
                        ],
                        QuestionImage = "android.jpg"
                    },
                    new Question
                    {
                        Text = "Which technology is used to connect devices wirelessly over short distances?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Bluetooth", IsCorrect = true },
                            new() { Text = "Wi-Fi", IsCorrect = false },
                            new() { Text = "NFC", IsCorrect = false },
                            new() { Text = "Infrared", IsCorrect = false }
                        ],
                        QuestionImage = "wireless_communication.jpg"
                    }
                ],
                QuizCategory.Entertainment =>
                [
                    new Question
                    {
                        Text = "Who played Jack in the movie Titanic?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Leonardo DiCaprio", IsCorrect = true },
                            new() { Text = "Brad Pitt", IsCorrect = false },
                            new() { Text = "Tom Cruise", IsCorrect = false },
                            new() { Text = "Johnny Depp", IsCorrect = false }
                        ],
                        QuestionImage = "titanic.jpg"
                    },
                    new Question
                    {
                        Text = "What is the highest-grossing movie of all time?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Avatar", IsCorrect = true },
                            new() { Text = "Avengers: Endgame", IsCorrect = false },
                            new() { Text = "Titanic", IsCorrect = false },
                            new() { Text = "The Lion King", IsCorrect = false }
                        ],
                        QuestionImage = "movie.jpg"
                    },
                    new Question
                    {
                        Text = "Who sang 'Shape of You'?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Ed Sheeran", IsCorrect = true },
                            new() { Text = "Shawn Mendes", IsCorrect = false },
                            new() { Text = "Justin Bieber", IsCorrect = false },
                            new() { Text = "Sam Smith", IsCorrect = false }
                        ],
                        QuestionImage = "song.jpg"
                    },
                    new Question
                    {
                        Text = "What year was the first Harry Potter movie released?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "2001", IsCorrect = true },
                            new() { Text = "2000", IsCorrect = false },
                            new() { Text = "2002", IsCorrect = false },
                            new() { Text = "1999", IsCorrect = false }
                        ],
                        QuestionImage = "harry_potter.jpg"
                    },
                    new Question
                    {
                        Text = "What is the name of the coffee shop in Friends?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Central Perk", IsCorrect = true },
                            new() { Text = "Coffee Haven", IsCorrect = false },
                            new() { Text = "Cafe Central", IsCorrect = false },
                            new() { Text = "Friends Cafe", IsCorrect = false }
                        ],
                        QuestionImage = "friends.jpg"
                    }
                ],
                QuizCategory.History =>
                [
                    new Question
                    {
                        Text = "Who was the first President of the United States?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "George Washington", IsCorrect = true },
                            new() { Text = "Abraham Lincoln", IsCorrect = false },
                            new() { Text = "Thomas Jefferson", IsCorrect = false },
                            new() { Text = "John Adams", IsCorrect = false }
                        ],
                        QuestionImage = "usa_president.jpg"
                    },
                    new Question
                    {
                        Text = "Which war ended in 1945?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "World War II", IsCorrect = true },
                            new() { Text = "World War I", IsCorrect = false },
                            new() { Text = "Cold War", IsCorrect = false },
                            new() { Text = "Vietnam War", IsCorrect = false }
                        ],
                        QuestionImage = "war.jpg"
                    },
                    new Question
                    {
                        Text = "Who discovered America?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Christopher Columbus", IsCorrect = true },
                            new() { Text = "Amerigo Vespucci", IsCorrect = false },
                            new() { Text = "Leif Erikson", IsCorrect = false },
                            new() { Text = "James Cook", IsCorrect = false }
                        ],
                        QuestionImage = "american_shores.jpg"
                    },
                    new Question
                    {
                        Text = "When was the Declaration of Independence signed?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "1776", IsCorrect = true },
                            new() { Text = "1783", IsCorrect = false },
                            new() { Text = "1801", IsCorrect = false },
                            new() { Text = "1754", IsCorrect = false }
                        ],
                        QuestionImage = "independence.jpg"
                    },
                    new Question
                    {
                        Text = "What empire did Genghis Khan rule?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Mongol Empire", IsCorrect = true },
                            new() { Text = "Ottoman Empire", IsCorrect = false },
                            new() { Text = "Roman Empire", IsCorrect = false },
                            new() { Text = "British Empire", IsCorrect = false }
                        ],
                        QuestionImage = "genghis_khan.jpg"
                    }
                ],
                QuizCategory.Politics =>
                [
                    new Question
                    {
                        Text = "Who is known as the Father of the Constitution?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "James Madison", IsCorrect = true },
                            new() { Text = "Alexander Hamilton", IsCorrect = false },
                            new() { Text = "Thomas Jefferson", IsCorrect = false },
                            new() { Text = "George Washington", IsCorrect = false }
                        ],
                        QuestionImage = "james_madison.jpg"
                    },
                    new Question
                    {
                        Text = "What political system is ruled by a king or queen?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Monarchy", IsCorrect = true },
                            new() { Text = "Democracy", IsCorrect = false },
                            new() { Text = "Communism", IsCorrect = false },
                            new() { Text = "Socialism", IsCorrect = false }
                        ],
                        QuestionImage = "political_system.jpg"
                    },
                    new Question
                    {
                        Text = "Who was the first female Prime Minister of the UK?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Margaret Thatcher", IsCorrect = true },
                            new() { Text = "Theresa May", IsCorrect = false },
                            new() { Text = "Angela Merkel", IsCorrect = false },
                            new() { Text = "Indira Gandhi", IsCorrect = false }
                        ],
                        QuestionImage = "uk_flag.jpg"
                    },
                    new Question
                    {
                        Text = "What year did the United Nations form?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "1945", IsCorrect = true },
                            new() { Text = "1919", IsCorrect = false },
                            new() { Text = "1939", IsCorrect = false },
                            new() { Text = "1950", IsCorrect = false }
                        ],
                        QuestionImage = "united_nations.jpg"
                    },
                    new Question
                    {
                        Text = "Which country has the largest democracy?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "India", IsCorrect = true },
                            new() { Text = "United States", IsCorrect = false },
                            new() { Text = "Brazil", IsCorrect = false },
                            new() { Text = "Australia", IsCorrect = false }
                        ],
                        QuestionImage = "democracy.jpg"
                    }
                ],
                QuizCategory.Geography =>
                [
                    new Question
                    {
                        Text = "What is the largest country in the world?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Russia", IsCorrect = true },
                            new() { Text = "Canada", IsCorrect = false },
                            new() { Text = "China", IsCorrect = false },
                            new() { Text = "United States", IsCorrect = false }
                        ],
                        QuestionImage = "globe.jpg"
                    },
                    new Question
                    {
                        Text = "Which river is the longest in the world?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Nile", IsCorrect = true },
                            new() { Text = "Amazon", IsCorrect = false },
                            new() { Text = "Yangtze", IsCorrect = false },
                            new() { Text = "Mississippi", IsCorrect = false }
                        ],
                        QuestionImage = "river.jpg"
                    },
                    new Question
                    {
                        Text = "What is the capital city of Australia?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Canberra", IsCorrect = true },
                            new() { Text = "Sydney", IsCorrect = false },
                            new() { Text = "Melbourne", IsCorrect = false },
                            new() { Text = "Brisbane", IsCorrect = false }
                        ],
                        QuestionImage = "australia.jpg"
                    },
                    new Question
                    {
                        Text = "Which desert is the largest in the world?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Sahara Desert", IsCorrect = false },
                            new() { Text = "Antarctic Desert", IsCorrect = true },
                            new() { Text = "Gobi Desert", IsCorrect = false },
                            new() { Text = "Kalahari Desert", IsCorrect = false }
                        ],
                        QuestionImage = "desert.jpg"
                    },
                    new Question
                    {
                        Text = "What is the smallest country in the world by area?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Vatican City", IsCorrect = true },
                            new() { Text = "Monaco", IsCorrect = false },
                            new() { Text = "San Marino", IsCorrect = false },
                            new() { Text = "Liechtenstein", IsCorrect = false }
                        ],
                        QuestionImage = "vatican.jpg"
                    }
                 ],
                 QuizCategory.Sport =>
                 [
                    new Question
                    {
                        Text = "What sport is known as 'The Beautiful Game'?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Football (Soccer)", IsCorrect = true },
                            new() { Text = "Basketball", IsCorrect = false },
                            new() { Text = "Tennis", IsCorrect = false },
                            new() { Text = "Cricket", IsCorrect = false }
                        ],
                        QuestionImage = "beuatiful_game.jpg"
                    },
                    new Question
                    {
                        Text = "What is the national sport of Japan?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Sumo Wrestling", IsCorrect = true },
                            new() { Text = "Baseball", IsCorrect = false },
                            new() { Text = "Judo", IsCorrect = false },
                            new() { Text = "Karate", IsCorrect = false }
                        ],
                        QuestionImage = "japan.jpg"
                    },
                    new Question
                    {
                        Text = "What is the term for scoring three goals in a single game in hockey?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Hat Trick", IsCorrect = true },
                            new() { Text = "Triple Play", IsCorrect = false },
                            new() { Text = "Power Play", IsCorrect = false },
                            new() { Text = "Grand Slam", IsCorrect = false }
                        ],
                        QuestionImage = "hockey.jpg"
                    },
                    new Question
                    {
                        Text = "Which country has won the most FIFA World Cups?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "Brazil", IsCorrect = true },
                            new() { Text = "Germany", IsCorrect = false },
                            new() { Text = "Italy", IsCorrect = false },
                            new() { Text = "Argentina", IsCorrect = false }
                        ],
                        QuestionImage = "fifa.jpg"
                    },
                    new Question
                    {
                        Text = "What is the top prize for a tennis player at Wimbledon?",
                        Category = category.ToString(),
                        Answers =
                        [
                            new() { Text = "The Championship Trophy", IsCorrect = false },
                            new() { Text = "The Venus Rosewater Dish", IsCorrect = true },
                            new() { Text = "The Grand Slam Trophy", IsCorrect = false },
                            new() { Text = "The Grass Court Cup", IsCorrect = false }
                        ],
                        QuestionImage = "tennis.jpg"
                    }
                ],
                _ => []
            };
        }
    }
}
