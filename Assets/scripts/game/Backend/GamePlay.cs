using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GamePlay
{
    private List<GameObject> BlueBricks = new List<GameObject>();
    private List<GameObject> RedBricks = new List<GameObject>();
    private List<GameObject> GreenBricks = new List<GameObject>();
    private List<GameObject> YellowBricks = new List<GameObject>();
    public void GameStuff()
    {
        
        var red = GameObject.Find("Red");
        Debug.Log("parent: " + red);
        for (int i = 0; i <  red.transform.childCount; i++)
        {
            RedBricks.Add(red.transform.GetChild(i).gameObject);
        }

      
        var blue = GameObject.Find("Blue");
        Debug.Log("parent: " + blue);
        for (int i = 0; i < blue.transform.childCount; i++)
        {
            this.BlueBricks.Add(blue.transform.GetChild(i).gameObject);
            Debug.Log("added: " + blue.transform.GetChild(i).gameObject.name);
        }

        foreach (var brick in this.BlueBricks)
        {
            Debug.Log(brick.gameObject.name);
        }
        Debug.Log(this.BlueBricks.Count);
      
        var green = GameObject.Find("Green");
        for (int i = 0; i < green.transform.childCount; i++)
        {
            GreenBricks.Add(green.transform.GetChild(i).gameObject);
        }
   
        var Yellow = GameObject.Find("Yellow");
        for (int i = 0; i < Yellow.transform.childCount; i++)
        {
            YellowBricks.Add(Yellow.transform.GetChild(i).gameObject);
        }

    }

    public GameObject getBlueBrick(int number)
    {
        GameObject tempBrick = this.BlueBricks.ElementAt(number);
        return tempBrick;
    }
    public GameObject getRedBrick(int number)
    {
        GameObject tempBrick = RedBricks.ElementAt(number);
        return tempBrick;
    }
    public GameObject getGreenBrick(int number)
    {
        GameObject tempBrick = GreenBricks.ElementAt(number);
        return tempBrick;
    }
    public GameObject getYellowBrick(int number)
    {
        GameObject tempBrick = YellowBricks.ElementAt(number);
        return tempBrick;
    }

}
