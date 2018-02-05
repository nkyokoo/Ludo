
using UnityEngine;
using System.Collections;
using System.Net.Mime;
using UnityEngine.UI;


public class DieTurn : MonoBehaviour{
	
     public static void changeSide(int side, GameObject gameObject)
     {
	     Text txt = gameObject.GetComponent<Text>();
	     
        switch (side)
        {
            case 1: txt.text = "1";
	            break;
            case 2:  txt.text = "2";
	            break;
            case 3:  txt.text = "3";
	            break;
            case 4:  txt.text = "4";
	            break;
            case 5:  txt.text = "5";
	            break;
            case 6:  txt.text = "6";
	            break;
        }
        
     }
		
}
