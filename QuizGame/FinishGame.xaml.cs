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
    /// Interaktionslogik für FinishGame.xaml
    /// </summary>
    public partial class FinishGame : Page
    {
        MainWindow mainWindow;
        int score;
        public FinishGame(MainWindow wnd, int score)
        {
            InitializeComponent();
            mainWindow = wnd;
            this.score = score;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lblPlayerPoints.Content = "Deine Punkte: "+ score.ToString();
        }

        private void BtnSendToDB_Click(object sender, RoutedEventArgs e)
        {
            //Write Points into Database
            currentPlayer player;
            string name = tbxName.Text;
            if (name != "")
            {
                player = new currentPlayer(score,name);
            }
            else
            {
                player = new currentPlayer(score);
            }
            player.PunkteEintragen();
            mainWindow.ToGameMenu();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToGameMenu();
        }
    }
}
