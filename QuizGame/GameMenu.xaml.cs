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

        }

        private void BtnHighScore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAddQuestion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
