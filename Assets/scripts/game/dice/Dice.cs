using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : DieTurn {
	public GameObject gameObject = null;

	public void RollDice ()
	{
		System.Random r = new System.Random();
		int rInt = r.Next(1, 7);
		this.changeSide(rInt, gameObject);
		Debug.Log(rInt);
		

	}
	

}
