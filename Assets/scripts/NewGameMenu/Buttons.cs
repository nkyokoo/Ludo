using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using game.player;
using UnityEngine.SceneManagement;

namespace Assets.scripts.mainMenu.NewGameMenu
{
    class Buttons : ButtonsInterface
    {
        public void StartGame()
        {
           
            SceneManager.LoadScene("game");
            
        }

        public void SaveConfig()
        {
            PlayerDataController playerDataController = new PlayerDataController();
            playerDataController.SavePlayerData();
        }

        public void BackButton()
        {
            SceneManager.LoadScene("mainmenu");
        }
    }
}
