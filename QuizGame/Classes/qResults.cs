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
        //Constructor for show Results
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

        //Constructor for add Results
        public qResults(Dictionary<string,string> results)
        {
            ctx = new QuizDBContext();
            this.results = results;
        }

        //Add the Results
        public void AddAnswers(int qID)
        {
            Results newResults = new Results();
            Questions q = ctx.Questions.Where(x => x.qID.Equals(qID)).FirstOrDefault();
            newResults.Questions = q;
            newResults.trueRESULT = this.results["resultTrue"];
            newResults.resultONE = this.results["resultOne"];
            newResults.relultTWO = this.results["resultTwo"];
            newResults.resultTHREE = this.results["resultThree"];
            ctx.Results.Add(newResults);
            ctx.SaveChanges();
            
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
