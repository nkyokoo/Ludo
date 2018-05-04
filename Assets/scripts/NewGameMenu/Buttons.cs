using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using game.player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.scripts.mainMenu.NewGameMenu
{
   public class Buttons : MonoBehaviour, ButtonsInterface
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

        public void exitGame()
        {
          
        }
    }
}
