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
    /// Interaktionslogik für AddQuestion.xaml
    /// </summary>
    public partial class AddQuestion : Page
    {
        MainWindow mainWindow;
        public AddQuestion(MainWindow wnd)
        {
            InitializeComponent();
            mainWindow = wnd;
        }

        private void Tbx_GotFocus(object sender, RoutedEventArgs e)
        {
            //mark the focused text
            TextBox tbxSender = sender as TextBox;
            tbxSender.SelectAll();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.ToGameMenu();
        }

        private void BtnAddQuestion_Click(object sender, RoutedEventArgs e)
        {
            //if the Question is already in the database,
            //dont add the question again
            if (rQuestion.IsQuestionInDB(tbxQueestion.Text))
            {
                MessageBox.Show("Frage ist bereits vorhanden");
            }
            else
            {
                Dictionary<string, string> results = new Dictionary<string, string>();
                results.Add("resultTrue", tbxResultOne.Text);
                results.Add("resultOne", tbxResultTwo.Text);
                results.Add("resultTwo", tbxResultThree.Text);
                results.Add("resultThree", tbxResultFour.Text);
                rQuestion newQuestion = new rQuestion(tbxQueestion.Text, results);
                newQuestion.AddQuestion();
                MessageBox.Show("Frage hinzugefügt");
            }

        }
    }
}
