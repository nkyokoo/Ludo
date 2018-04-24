namespace game.player
{
    public class PlayerController : PlayerInterface
    {
        private PlayerTeams currentTeam;


        public void setTeam(PlayerTeams team)
        {
            currentTeam = team;
        }

        public PlayerTeams getTeam()
        {
            return currentTeam;
        }

        public static PlayerController Controller()
        {
            var playerController = new PlayerController();
            return playerController;
        }

        public void teamManager()
        {
            var turns = TurnController.currentTurn;

            switch (turns)
            {
                case PlayerTurns.PLAYER1:
                    setTeam(PlayerTeams.BLUE);
                    break;
                case PlayerTurns.PLAYER2:
                    setTeam(PlayerTeams.RED);
                    break;
                case PlayerTurns.PLAYER3:
                    setTeam(PlayerTeams.GREEN);
                    break;
                case PlayerTurns.PLAYER4:
                    setTeam(PlayerTeams.YELLOW);
                    break;
            }
        }
    }
}