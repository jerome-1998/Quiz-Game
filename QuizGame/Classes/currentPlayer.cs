using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Classes
{
    class currentPlayer
    {
        private string name;
        private int score;

        private static QuizDBContext ctx = new QuizDBContext();
        public currentPlayer(int score, string name = "Gast")
        {
            this.name = name;
            this.score = score;
        }

        public void PunkteEintragen()
        {
            Player player = new Player();
            player.playerNAME = name;
            player.playerPUNKTE = score;
            ctx.Player.Add(player);
            ctx.SaveChanges();
        }
    }
}
