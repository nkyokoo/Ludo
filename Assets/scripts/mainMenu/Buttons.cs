using System.Collections;
using System.Collections.Generic;
using Assets.scripts.mainMenu.NewGameMenu;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour, ButtonsInterface
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
