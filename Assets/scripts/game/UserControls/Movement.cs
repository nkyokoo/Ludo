using System.Collections;
using System.Collections.Generic;
using Assets.scripts.game;
using game.player;
using JetBrains.Annotations;
using UnityEngine;

public class Movement : MonoBehaviour {

	Vector3 newPosition;
	private GameObject playerBrick;

    void Awake()
    {
        GamePlay.GetGamePlay().GameStuff();
        PlayerController.teamManager();
       
    }

    void Start() {
		newPosition = transform.position;
        
	}
	void Update()
	{
	    playerBrick = PlayerController.tempbrick;
		if (Input.GetMouseButtonDown(0))
		{
			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				newPosition = hit.point;
			    playerBrick.transform.position = newPosition;
			

		    }

		 }

       }

	}
