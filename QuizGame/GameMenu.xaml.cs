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
using QuizGame.Classes; //rausmachen, nur für test

namespace QuizGame
{
    /// <summary>
    /// Interaktionslogik für GameMenu.xaml
    /// </summary>
    public partial class GameMenu : Page
    {
        MainWindow mainWindow;
        public GameMenu(MainWindow wnd)
        {
            InitializeComponent();
            mainWindow = wnd;
            
        }

        private void BtnStartQuiz_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            rQuestion q = game.getQuestion();
            if (q != null)
            {
                foreach (KeyValuePair<string, string> item in q.getResults())
                {
                    MessageBox.Show(item.Value);
                }
            }
            else
            {
                MessageBox.Show("Keine Fragen mehr verfügbar");
            }
            
            //mainWindow.ToQuiz();
        }

        private void BtnHighScore_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToHighScore();
        }

        private void BtnAddQuestion_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToAddQuestion();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
