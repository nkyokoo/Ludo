using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {


	public void startGame () {
		SceneManager.LoadScene("game");
		
	}
	

	public void exitGame () {
		System.Environment.Exit(1);
		
	}
}
