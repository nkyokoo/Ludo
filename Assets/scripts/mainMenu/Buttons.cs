using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {


	public void startGame () {
		Application.LoadLevel("game");
		
	}
	

	public void exitGame () {
		System.Environment.Exit(1);
		
	}
}
