using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBehaviour : MonoBehaviour
{
    public bool showWinScreen = false;
    public string labelText = "collect all 4 items and win your freedom";
    public int maxItems = 4;
    private int itemsCollected = 0;

    public bool showLossScreen = false;

    public int Items
    {
        get
        {
            return itemsCollected;
        }
        set
        {
            itemsCollected = value;
            if (itemsCollected >= maxItems)
            {
                labelText = "You have found all the items";
                showWinScreen = true;// to show winning screen
                Time.timeScale = 0f;// to stop game after wining
            }
            else
            {
                labelText = "Item found, only" + (maxItems - itemsCollected) + "more to go!";
            }
        }
    }


    private int playerHP = 10;
    public int HP
    {
        get
        {
            return playerHP;
        }
        set
        {
            playerHP = value;
            Debug.LogFormat("Lives: {0}", playerHP);
            if(playerHP <= 0)
            {
                labelText = "You want another life with that?";
                showLossScreen = true;
                Time.timeScale = 0;
            }
            else
            {
                labelText = "Ouch ... Got hit";
            }
        }
    }


    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player Health:" + playerHP);
        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected:" + itemsCollected);
        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

        if (showWinScreen)
        {
            if (GUI.Button(new Rect(Screen.width/2-100, Screen.height/2-50,200,100),"You WON!"))
            {
                Utilities.RestartLevel();
            }
        }

        //Showing Loss Screen#####

        if (showLossScreen)
        {
            if (GUI.Button(new Rect(Screen.width/2-100,Screen.height/2-50,200,100), "You Lost ..."))
            {
                Utilities.RestartLevel();
            }
        }
    }
}