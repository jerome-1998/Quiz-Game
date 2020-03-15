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
        private int score;
        private currentPlayer currentPlayer;
        private rQuestion question;
        
        public Game()
        {
            score = 0;
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
                    string asked = "";
                    foreach(int i in askedQuestions)
                    {
                        asked += i.ToString()+"\t";
                    }
                    return question;
                }
                else if(askedQuestions.Count == rQuestion.MAXQuestions)
                {
                    break;
                }
            }
            return null;
        }

        private static void setAskedQuestionsToDefault()
        {
            askedQuestions.Clear();
        }

        public void AddScore(int toAdd)
        {
            score += toAdd;
        }

        public int currentScore
        {
            get
            {
                return score;
            }
        }

        public void ExitGame(string playername = "Gast")
        {
            setAskedQuestionsToDefault();
            currentPlayer currentPlayer = new currentPlayer(score,playername);
        }

    }
}
