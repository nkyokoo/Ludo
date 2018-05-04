using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Assets.scripts.game.dice;
using game.player;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour {
	public static PlayerTeams currentTeam;
	public static PlayerTurns currentTurn;
	public GameObject currentTurnTxt;
    public static GameObject tempbrick;
    private Text txt;
	public GameObject rollDiceBtn;
    public static GamePlay game = new GamePlay();


    // Use this for initialization

    void Start()
	{
	  txt = currentTurnTxt.GetComponent<Text>();

		currentTurn = PlayerTurns.PLAYER1;
		currentTeam = PlayerTeams.BLUE;
	}
	
	// Update is called once per frame
	void Update() {
		if (GuiScript.state == DiceStates.Rolled)
		{
			rollDiceBtn.SetActive(false);
		}
		else if (GuiScript.state == DiceStates.Roll)
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
           

	public static void teamManager()
	{
	   
		switch (currentTurn)
		{
		        
			case PlayerTurns.PLAYER1:
				currentTeam = PlayerTeams.BLUE;
			    tempbrick = game.getBlueBrick(0);
                Debug.Log(tempbrick);
                break;
			case PlayerTurns.PLAYER2:
				currentTeam = PlayerTeams.RED;

                break;
			case PlayerTurns.PLAYER3:
				currentTeam = PlayerTeams.GREEN;

                break;
			case PlayerTurns.PLAYER4:
				currentTeam = PlayerTeams.YELLOW;
		
                break;
		}
	    Debug.Log("Current team: " +currentTeam);
    }
	public static void NextTurn()
	{
		switch (currentTurn)
		{
			
			case PlayerTurns.PLAYER1:
				currentTurn = PlayerTurns.PLAYER2;
				 teamManager();
				break;
			case PlayerTurns.PLAYER2:
				currentTurn =  PlayerTurns.PLAYER3;
				teamManager();
				break;
			case PlayerTurns.PLAYER3:
				currentTurn =  PlayerTurns.PLAYER4;
				teamManager();
				break;
			case PlayerTurns.PLAYER4:
				currentTurn =  PlayerTurns.PLAYER1;
				teamManager();
			break;
				
		}
	    Debug.Log("current turn:" + currentTurn);

    }


}
