using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using game.player;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

namespace Assets.scripts.game
{
   public class SelectObject
    {
        void select()
        {
            PlayerTeams tempteam;
         
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hitInfo = new RaycastHit();
                Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
                

            }
        }
    }
}
