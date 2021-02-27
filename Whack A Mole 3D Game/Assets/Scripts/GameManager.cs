using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int playtime = 10;
    int seconds, minutes;
    int curLevel = 1;
    int baseScore = 100;
    int scoreToReach;

    void Start()
    {
        scoreToReach = curLevel * baseScore;
        StartCoroutine("PlayTimer");
    }

    // IEnumerator is Time Based Function and going to return something
    IEnumerator PlayTimer()
    {
        
        while (playtime > 0)
        {
            yield return new WaitForSeconds(1);
            playtime--;
            Debug.Log("PLaytime is :"+ playtime);
            seconds = playtime % 60;
            minutes = playtime / 60 % 60;
            //Update UI
            UIManager.instance.UpdateTime(minutes,seconds);
        }
        Debug.Log("TIMER ENDED");
        // WIN Condition
        CheckForWin();
    }

    void CheckForWin()
    {
        if (ScoreManager.ReadScore() >= scoreToReach)
        {
            Debug.Log("You WON the level");
        }
        else
        {
            //GameOver
            Debug.Log("GAME OVER");
        }
    }
}
