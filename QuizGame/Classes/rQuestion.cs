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
        //Constructor for get Questions
        public rQuestion(int Auswahl)
        {
            
            Questions questions = ctx.Questions.Where(x => x.qID.Equals(Auswahl)).FirstOrDefault();
            qID = questions.qID;
            qText = questions.questionTEXT;
            results = new qResults(Auswahl);
        }
        //Constructor for add Questions
        public rQuestion(string question, Dictionary<string,string> results)
        {
            this.qText = question;
            this.results = new qResults(results);
        }

        public void AddQuestion()
        {
            //First add the Question, than add the results
            Questions question = new Questions();
            question.questionTEXT = this.qText;
            ctx.Questions.Add(question);
            ctx.SaveChanges();
            int qID = ctx.Questions.Where(x => x.questionTEXT.Equals(this.qText)).FirstOrDefault().qID;
            results.AddAnswers(qID);
        }

        public static bool IsQuestionInDB(string qText)
        {
            //Show if Questiontext is already in the Database
            ctx = new QuizDBContext();
            if (ctx.Questions.Where(x=>x.questionTEXT.Equals(qText)).FirstOrDefault()!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int MAXQuestions
        {
            get
            {
                return ctx.Questions.ToList().Count;
            }
        }
        
        public string questionText
        {
            get
            {
                return this.qText;
            }
        }

        public Dictionary<string,string> resultList
        {
            get
            {
                return results.getAnswers;
            }
            
        }
    }
}
