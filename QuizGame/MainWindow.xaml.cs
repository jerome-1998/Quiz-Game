using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizGame
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        AddQuestion addQuestion;
        GameMenu gameMenu;
        HighScore highScore;
        Quiz quiz;
        FinishGame finishGame;
        public MainWindow()
        {
            StartWindow start = new StartWindow();
            start.ShowDialog();
            InitializeComponent();
            
            addQuestion = new AddQuestion(this);
            gameMenu = new GameMenu(this);
            highScore = new HighScore(this);
            quiz = new Quiz(this);
            ToGameMenu();
        }

        public void ToAddQuestion()
        {
            myFrame.Content = addQuestion;
        }

        public void ToGameMenu()
        {
            myFrame.Content = gameMenu;
        }

        public void ToHighScore()
        {
            myFrame.Content = highScore;
        }

        public void ToQuiz()
        {
            myFrame.Content = quiz;
        }

        public void ToFinishGame(int score)
        {
            finishGame = new FinishGame(this, score);
            myFrame.Content = finishGame;
        }
    }
}
