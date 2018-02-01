using System.Collections;
using System.Collections.Generic;
using game.player;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {
	
	private PlayerTurns currentTurn;
	public GameObject gameObject;

	private Text txt;
	// Use this for initialization

	void Start ()
	{
	  txt = gameObject.GetComponent<Text>();

		currentTurn = PlayerTurns.PLAYER1;
	}
	
	// Update is called once per frame
	void Update () {

		switch (currentTurn)
		{
			case PlayerTurns.PLAYER1:
				txt.text = currentTurn.ToString().ToLower() + "'s turn";
				
				break;
			case PlayerTurns.PLAYER2:
				txt.text = currentTurn + "'s turn";
				
				break;
			case PlayerTurns.PLAYER3:
				txt.text = currentTurn + "'s turn";
				
				break;
			case PlayerTurns.PLAYER4:
				txt.text = currentTurn + "'s turn";
				
				break;
		}
		
	}

	public void nextTurn()
	{
		switch (currentTurn)
		{
			case PlayerTurns.PLAYER1:

				currentTurn = PlayerTurns.PLAYER2;
				break;
			case PlayerTurns.PLAYER2:

				currentTurn = PlayerTurns.PLAYER3;
				break;
			case PlayerTurns.PLAYER3:

				currentTurn = PlayerTurns.PLAYER4;
				break;
			case PlayerTurns.PLAYER4:
				
				currentTurn = PlayerTurns.PLAYER1;
				break;
		}
	}
}
