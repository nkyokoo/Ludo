using UnityEditor;
using UnityEngine;

namespace game.player
{
    public class PlayerController : PlayerControllerInterface
    {
     
        public PlayerTeams currentTeam = PlayerTeams.RED;
           
        public PlayerTeams getTeam()
        {            
            Debug.Log(currentTeam);
            return currentTeam;
        }

        public static PlayerController Controller()
        {
            
            var playerController = new PlayerController();
            return playerController;
        }

        public void teamManager()
        {
            
            PlayerTurns turns = TurnController.getCurrentTurn();
         
       
            switch (turns)
            {
                case PlayerTurns.PLAYER1:
                    currentTeam = PlayerTeams.BLUE;
                    break;
                case PlayerTurns.PLAYER2:
                    currentTeam = PlayerTeams.RED;
                    break;
                case PlayerTurns.PLAYER3:
                    currentTeam = PlayerTeams.GREEN;
                    break;
                case PlayerTurns.PLAYER4:
                    currentTeam = PlayerTeams.YELLOW;
                    break;
            }
        }
    }
}