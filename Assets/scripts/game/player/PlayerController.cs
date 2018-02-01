using System;
using System.Collections;
using System.Collections.Generic;
using Assets.scripts.game.dice;
using game.player;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	
	private PlayerTurns currentTurn;
	public GameObject gameObject;

	private Text txt;
	public GameObject myButton;

	
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
				if (Dice.state == DiceStates.Rolled)
				{
					myButton.SetActive(false);
				}
				
				
				break;
			case PlayerTurns.PLAYER2:
				txt.text = currentTurn.ToString().ToLower() + "'s turn";
				if (Dice.state == DiceStates.Rolled)
				{
					myButton.SetActive(false);
				}
			
				
				break;
			case PlayerTurns.PLAYER3:
				txt.text = currentTurn.ToString().ToLower() + "'s turn";
				if (Dice.state == DiceStates.Rolled)
				{
					myButton.SetActive(false);
				}
				
				
				break;
			case PlayerTurns.PLAYER4:
				txt.text = currentTurn.ToString().ToLower() + "'s turn";
				if (Dice.state == DiceStates.Rolled)
				{
					myButton.SetActive(false);
				}
	
				
				break;
		}
		
	}

	public void nextTurn()
	{
		foreach (PlayerTurns turns in Enum.GetValues(typeof(PlayerTurns)))
		{
			if (currentTurn == turns)
			{
				currentTurn = turns + 1;
			
			}
			else
			{
				currentTurn = turns;
				break;
			}
			
			
		
		}
	}
}
