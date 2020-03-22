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
using System.Diagnostics;

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
        private static int points = 0;
        private Stopwatch watch =new Stopwatch();
        
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
            currentGame.ExitGame();
            resetWatch();
            Clean_Gui();
            mainWindow.ToFinishGame(points);
            resetPoints();
        }

        public void Click_CheckResult(object sender, RoutedEventArgs args)
        {
            if (((Button)sender).Name == "resultTrue")
            {
                MessageBox.Show("RICHTIG!");
                Clean_Gui();
                //Count until here
                points += getPoints();
                //start again to count
                resetWatch();
                watch.Start();
                NextQuestion();
            }
            else
            {
                //reset all
                MessageBox.Show("Die Antwort war leider falsch!");
                resetWatch();
                currentGame.ExitGame();
                Clean_Gui();
                mainWindow.ToFinishGame(points);
                resetPoints();
            }
        }

        private void CreateGUI()
        {
            //Count Seconds
            watch.Start();
            //Take a random Question from DB and show it
            NextQuestion();
        }

        private void NextQuestion()
        {
            lblGamePoints.Content = points.ToString();
            //Make a Button list with the results and shuffle the list, than create buttons
            List<Button> resultList = new List<Button>();
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
                    resultList.Add(tmpResults);
                    Shuffle(resultList);
                }
                foreach(Button b in resultList)
                {
                    spResults.Children.Add(b);
                }
            }
            else
            {
                //All Questions asked, reset all
                MessageBox.Show("Alle Fragen richtig beantwortet");
                resetWatch();
                currentGame.ExitGame();
                mainWindow.ToFinishGame(points);
                resetPoints();
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

        private void resetWatch()
        {
            watch.Stop();
            watch.Reset();
        }

        private int getPoints()
        {
            watch.Stop();
            TimeSpan ts = watch.Elapsed;
            return (int)((1 / ts.TotalSeconds) * 100);
        }

        private void resetPoints()
        {
            points = 0;
        }

        
    }
}
