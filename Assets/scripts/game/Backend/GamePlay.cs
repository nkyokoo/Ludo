using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay
{
    private List<GameObject> BlueBricks;
    public void GameStuff()
    {
        List<GameObject> RedBricks = new List<GameObject>();
        var red = GameObject.Find("Red");
        Debug.Log("parent: " + red);
        for (int i = 0; i <  red.transform.childCount; i++)
        {
            RedBricks.Add(red.transform.GetChild(i).gameObject);
        }

       BlueBricks = new List<GameObject>();
        var blue = GameObject.Find("Blue");
        Debug.Log("parent: " + blue);
        for (int i = 0; i < blue.transform.childCount; i++)
        {
            BlueBricks.Add(blue.transform.GetChild(i).gameObject);
            Debug.Log("added: " + blue.transform.GetChild(i).gameObject.name);
        }

        foreach (var brick in BlueBricks)
        {
            Debug.Log(brick.gameObject.name);
        }
        List<GameObject> GreenBicks = new List<GameObject>();
        var green = GameObject.Find("Green");
        for (int i = 0; i < green.transform.childCount; i++)
        {
            GreenBicks.Add(green.transform.GetChild(i).gameObject);
        }
        List<GameObject> YellowBicks = new List<GameObject>();
        var Yellow = GameObject.Find("Yellow");
        for (int i = 0; i < Yellow.transform.childCount; i++)
        {
            YellowBicks.Add(Yellow.transform.GetChild(i).gameObject);
        }

    }

    public List<GameObject> getBlueBricks()
    {
        return BlueBricks;
    }

    public static GamePlay GetGamePlay()
    {
        return new GamePlay();
    }
}
