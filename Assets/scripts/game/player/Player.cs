using JetBrains.Annotations;

namespace game.player
{
    public class Player : PlayerInterface
    {
        public void setName()
        {
            throw new System.NotImplementedException(); 
        }

        public void setTeam(PlayerTeams team)
        {
            throw new System.NotImplementedException();
        }

        public bool isAI()
        {
            throw new System.NotImplementedException();
        }

        public static Player getPlayer()
        {
            Player player = new Player();
            return player;
        }

        public void PlayerCore()
        {
         
     
        }
    }
}