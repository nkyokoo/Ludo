﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {


	public void startGame () {
		SceneManager.LoadScene("createnewgame");
		
	}
	

	public void exitGame () {
		Application.Quit();
		
	}
}
