using System.Collections;
using System.Collections.Generic;
using Assets.scripts.game;
using game.player;
using JetBrains.Annotations;
using UnityEngine;

public class Movement : MonoBehaviour {

	Vector3 newPosition;
	private GameObject playerBrick;
    public LayerMask hitLayers;
    void Awake()
    {
         PlayerController.game.GameStuff();
        PlayerController.teamManager();
       
    }

    void Start() {
		newPosition = transform.position;
        playerBrick = PlayerController.tempbrick;
    }

    void Update()
	{
        
	    if (Input.GetMouseButtonDown(0))
	    {
	        playerBrick = PlayerController.tempbrick;
	        Vector3 mouse = Input.mousePosition;
	        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
	        RaycastHit hit;
	        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
	        {
	            playerBrick.transform.position = hit.point;
	        }

	    }

	}

	}
