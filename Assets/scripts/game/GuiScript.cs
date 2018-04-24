using System.Collections;
using System.Collections.Generic;
using System;
using Assets.scripts.game.dice;
using UnityEngine;
using Random = System.Random;

public class GuiScript : MonoBehaviour {

    public GameObject gameObject;
    public static DiceStates state;
    Random rnd = new Random();
    public int NumberGenerator(int numberOfSides)
    {
        int ret;
            ret = rnd.Next(1, numberOfSides);
        
        return ret;
    }
    
    public void rollDice ()
    {
        int rInt = NumberGenerator(6);
        DieTurn.changeSide(rInt, gameObject);
        state = DiceStates.Rolled;
    }
	
    public void endTurn()
    {
         TurnController.NextTurn();
        if (state == DiceStates.Rolled)
        {
            state = DiceStates.Roll;
        }


    }

}
