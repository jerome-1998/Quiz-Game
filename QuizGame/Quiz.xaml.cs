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
    /// Interaktionslogik für Quiz.xaml
    /// </summary>
    public partial class Quiz : Page
    {
        MainWindow mainWindow;
        private static Random rand = new Random();
        public static void Shuffle<T>(List<T> inputList)
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
        public Quiz(MainWindow wnd)
        {
            InitializeComponent();
            mainWindow = wnd;
        }
    }
}
