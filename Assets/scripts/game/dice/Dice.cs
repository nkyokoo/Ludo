using System;
using System.Collections;
using System.Collections.Generic;
using Assets.scripts.game.dice;
using UnityEngine;
using UnityEngine.UI;

public class Dice : DieTurn {
	public GameObject gameObject = null;
	public static DiceStates state;
	public void RollDice ()
	{
		
		System.Random r = new System.Random();
		int rInt = r.Next(1, 7);
		this.changeSide(rInt, gameObject);
		state = DiceStates.Rolled;
	}
	

}
