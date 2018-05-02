using JetBrains.Annotations;

namespace game.player
{
    public class Player : PlayerInterface
    {
  
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
            throw new System.NotImplementedException();
        }

        public string getTeam()
        {
            throw new System.NotImplementedException();
        }

        public bool isAI()
        {
            throw new System.NotImplementedException();
        }
    }
}