using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Classes
{
    class qResults
    {
        private int rID;
        private Dictionary<string,string> results = new Dictionary<string, string>();

        private QuizDBContext ctx;
        public qResults(int qAuswahl)
        {
            ctx = new QuizDBContext();
            Results resultsDB = ctx.Results.Where(x => x.Questions.qID.Equals(qAuswahl)).FirstOrDefault();
            rID = resultsDB.rID;
            results.Add("resultOne", resultsDB.resultONE);
            results.Add("resultTwo", resultsDB.relultTWO);
            results.Add("resultThree", resultsDB.resultTHREE);
            results.Add("resultTrue", resultsDB.trueRESULT);
        }

        public Dictionary<string,string> getAnswers
        {
            get
            {
                return results;
            }
        }
    }
}
