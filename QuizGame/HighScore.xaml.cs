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
    /// Interaktionslogik für HighScore.xaml
    /// </summary>
    public partial class HighScore : Page
    {
        MainWindow mainWindow;
        public HighScore(MainWindow wnd)
        {
            InitializeComponent();
            mainWindow = wnd;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //take top ten players
            QuizDBContext ctx = new QuizDBContext();
            List<Player> playerList = ctx.Player.OrderByDescending(x => x.playerPUNKTE).ThenBy(x => x.playerNAME).Take(10).ToList();
            int nmbr = 1;
            foreach(Player p in playerList)
            {
                StackPanel spColumn = new StackPanel();
                spColumn.Orientation = Orientation.Horizontal;
                spColumn.HorizontalAlignment = HorizontalAlignment.Center;

                Label playerRank = new Label();
                playerRank.Content = nmbr.ToString();
                playerRank.Width = 100;
                nmbr++;
                spColumn.Children.Add(playerRank);
                Label playerName = new Label();
                playerName.Content = p.playerNAME;
                playerName.Width = 300;
                spColumn.Children.Add(playerName);
                Label playerScore = new Label();
                playerScore.Content = p.playerPUNKTE;
                playerScore.Width = 300;
                spColumn.Children.Add(playerScore);
                spHighScoreList.Children.Add(spColumn);
            }
            //parentGrid.DataContext = playerList;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            spHighScoreList.Children.Clear();
            mainWindow.ToGameMenu();
        }
    }
}
