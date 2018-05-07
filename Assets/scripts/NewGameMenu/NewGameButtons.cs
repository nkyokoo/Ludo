using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using game.player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.scripts.mainMenu.NewGameMenu
{
   public class NewGameButtons : MonoBehaviour, ButtonsInterface
    {
        PlayerDataController playerDataController = new PlayerDataController();
        public void StartGame()
        {
            SceneManager.LoadScene("game");
            
        }
        public void SaveConfig()
        {
            playerDataController.SavePlayerData();
        }

        public void BackButton()
        {
            SceneManager.LoadScene("mainmenu");
        }

        public void exitGame()
        {
          
        }
    }
}
