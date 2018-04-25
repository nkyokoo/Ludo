using System;

namespace game.player
{
    public interface PlayerInterface
    {
        void setTeam(PlayerTeams team);
        PlayerTeams getTeam();
    }
}