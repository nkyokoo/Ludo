using System.Collections;
using System.Collections.Generic;
using game.player;
using JetBrains.Annotations;
using UnityEngine;

public class Movement : MonoBehaviour {

	Vector3 newPosition;
	private GameObject playerBrick;
	
	void Start() {
		Player.getPlayer().PlayerCore();
		newPosition = transform.position;
		PlayerTeams tempTeam = PlayerController.Controller().currentTeam;
		Debug.Log(tempTeam);
		switch (tempTeam)
		{
			case PlayerTeams.BLUE:
				playerBrick = GameObject.Find("Blueplayer1");
				Debug.Log(playerBrick);
				break;
		}
		
	}
	void Update()
	{
		Player.getPlayer().PlayerCore();
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
