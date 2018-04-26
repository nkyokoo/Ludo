using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.scripts.game.dice;
using game.player;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class TurnController : MonoBehaviour {
	
	public static PlayerTurns currentTurn;
	public GameObject currentTurnTxt;

	private Text txt;
	public GameObject rollDiceBtn;

	
	// Use this for initialization

	void Start()
	{
	  txt = currentTurnTxt.GetComponent<Text>();

		currentTurn = PlayerTurns.PLAYER1;
	}
	
	// Update is called once per frame
	void Update() {
		if (GuiScript.state == DiceStates.Rolled)
		{
			rollDiceBtn.SetActive(false);
		}else if (GuiScript.state == DiceStates.Roll)
		{
			rollDiceBtn.SetActive(true);
		}
			
		switch (currentTurn)
		{
			case PlayerTurns.PLAYER1:
				txt.text = currentTurn.ToString().ToLower() + "'s turn";
			
				
				break;
			case PlayerTurns.PLAYER2:
				txt.text = currentTurn.ToString().ToLower() + "'s turn";
			
			
				
				break;
			case PlayerTurns.PLAYER3:
				txt.text = currentTurn.ToString().ToLower() + "'s turn";
			
				
				break;
			case PlayerTurns.PLAYER4:
				txt.text = currentTurn.ToString().ToLower() + "'s turn";
		
				break;
		}
		
	}

	public static void NextTurn()
	{
		
		switch (currentTurn)
		{
			case PlayerTurns.PLAYER1:
				currentTurn = PlayerTurns.PLAYER2;
				break;
			case PlayerTurns.PLAYER2:
				currentTurn =  PlayerTurns.PLAYER3;
				break;
			case PlayerTurns.PLAYER3:
				currentTurn =  PlayerTurns.PLAYER4;
				break;
			case PlayerTurns.PLAYER4:
				currentTurn =  PlayerTurns.PLAYER1;
			break;
				
		}
	

	}

	public static PlayerTurns getCurrentTurn()
	{
		return currentTurn;
	}
}
