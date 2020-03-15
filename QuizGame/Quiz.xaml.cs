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
using QuizGame.Classes;

namespace QuizGame
{
    /// <summary>
    /// Interaktionslogik für Quiz.xaml
    /// </summary>
    public partial class Quiz : Page
    {
        MainWindow mainWindow;
        private static Random rand = new Random();
        private Game currentGame;
        
        public Quiz(MainWindow wnd)
        {
            currentGame = new Game();
            InitializeComponent();
            mainWindow = wnd;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            CreateGUI();
        }

        private void BtnExitGame_Click(object sender, RoutedEventArgs e)
        {
            //mainWindow.ToFinishGame(currentGame.currentScore);
            currentGame.ExitGame();
            Clean_Gui();
            mainWindow.ToGameMenu();
        }

        private void CreateGUI()
        {
            //Take a random Question
            NextQuestion();
        }

        public void Click_CheckResult(object sender, RoutedEventArgs args)
        {
            if (((Button)sender).Name == "resultTrue")
            {
                MessageBox.Show("RICHTIG!");
                Clean_Gui();
                NextQuestion();
            }
            else
            {
                MessageBox.Show("Die Antwort war leider falsch!");
                currentGame.ExitGame();
                mainWindow.ToGameMenu();
            }
        }

        private void NextQuestion()
        {
            rQuestion q = currentGame.getQuestion();
            if (q != null)
            {
                lblQuestion.Content = q.questionText;
                foreach (KeyValuePair<string, string> item in q.resultList)
                {
                    Button tmpResults = new Button();
                    tmpResults.Content = item.Value;
                    tmpResults.Name = item.Key;
                    tmpResults.Click += new RoutedEventHandler(Click_CheckResult);
                    spResults.Children.Add(tmpResults);
                }
            }
            else
            {
                MessageBox.Show("Alle Fragen richtig beantwortet");
                currentGame.ExitGame();
                mainWindow.ToGameMenu();
            }
        }

        private void Clean_Gui()
        {
            spResults.Children.Clear();
        }

        private void Shuffle<T>(List<T> inputList)
        {
            int iIndex;
            T tTmp;
            for (int i = 1; i < inputList.Count; ++i)
            {
                iIndex = rand.Next(i + 1);
                tTmp = inputList[i];
                inputList[i] = inputList[iIndex];
                inputList[iIndex] = tTmp;
            }
        }

        
    }
}
