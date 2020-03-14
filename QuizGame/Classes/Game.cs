using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Classes
{
    class Game
    {
        private Random rand = new Random();
        private static List<int> askedQuestions = new List<int>();

        private Player currentPlayer;
        private rQuestion question;
        
        public Game()
        {
            currentPlayer = new Player();
        }

        public rQuestion getQuestion()
        {
            while(true)
            {
                int nmbr = rand.Next(rQuestion.MAXQuestions);
                if(!askedQuestions.Contains(nmbr))
                {
                    question = new rQuestion(nmbr);
                    askedQuestions.Add(nmbr);
                    return question;
                }
                else if(askedQuestions.Count == rQuestion.MAXQuestions)
                {
                    break;
                }
            }
            return null;
        }

        public static void setAskedQuestionsToDefault()
        {
            askedQuestions.Clear();
        }

    }
}
