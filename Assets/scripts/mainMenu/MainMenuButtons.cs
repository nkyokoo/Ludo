using System.Collections;
using System.Collections.Generic;
using Assets.scripts.mainMenu.NewGameMenu;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour, ButtonsInterface
{
    public void StartGame()
    {
        SceneManager.LoadScene("createnewgame");

    }
    public void SaveConfig()
    {
        
    }
    public void BackButton()
    {
        
    }
    public void exitGame () {
		Application.Quit();
		
	}
}
