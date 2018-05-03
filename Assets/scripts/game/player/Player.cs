using JetBrains.Annotations;

namespace game.player
{
    public class Player : PlayerInterface
    {
        private string Playername;
        private string PlayerTeam;
        private bool ai;
  
        public static Player getPlayer()
        {
            Player player = new Player();
            return player;
        }

        public void PlayerCore()
        {
         
     
        }

        public string getName()
        {
            return Playername;
        }

        public string getTeam()
        {
            return PlayerTeam;
        }

        public bool isAI()
        {
            return ai;
        }
    }
}