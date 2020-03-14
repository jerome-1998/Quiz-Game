using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Classes
{
    class rQuestion
    {
        private int qID;
        private string qText;
        private qResults results;

        private static QuizDBContext ctx = new QuizDBContext();
        public rQuestion(int Auswahl)
        {
            Questions questions = ctx.Questions.Where(x => x.qID.Equals(Auswahl)).FirstOrDefault();
            qID = questions.qID;
            qText = questions.questionTEXT;
            results = new qResults(Auswahl);
        }

        public static int MAXQuestions
        {
            get
            {
                return ctx.Questions.ToList().Count;
            }
        }
        
        public string getQuestion()
        {
            return this.qText;
        }

        public Dictionary<string,string> getResults()
        {
            return results.getAnswers;
        }
    }
}
