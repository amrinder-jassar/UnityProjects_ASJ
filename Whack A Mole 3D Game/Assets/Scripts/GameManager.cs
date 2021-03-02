using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    //TIMER
    int playtime = 10;
    int seconds, minutes;

    //LEVEL & SCORE
    public static int curLevel = 1;
    int baseScore = 100;
    int scoreToReach;

    static bool hasLost;

    [HideInInspector] public bool countDownDone;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        if (hasLost)
        {
            hasLost = false;
            ScoreManager.ResetScore();
            curLevel = 1;
        }
        scoreToReach = curLevel * baseScore * curLevel;
        ScoreManager.scoreToReach = scoreToReach;
        UIManager.instance.UpdateUI(ScoreManager.ReadScore(),scoreToReach);
        //StartCoroutine("PlayTimer");
    }

    // IEnumerator is Time Based Function and going to return something
    IEnumerator PlayTimer()
    {
        
        while (playtime > 0)
        {
            yield return new WaitForSeconds(1);
            playtime--;
            //Debug.Log("PLaytime is :"+ playtime);
            seconds = playtime % 60;
            minutes = playtime / 60 % 60;
            //Update UI
            UIManager.instance.UpdateTime(minutes,seconds);
        }
        //Debug.Log("TIMER ENDED");
        // WIN Condition
        CheckForWin();
    }

    void CheckForWin()
    {
        if (ScoreManager.ReadScore() >= scoreToReach)
        {
            //Debug.Log("You WON the level");
            curLevel++;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            hasLost = true;
            ScoreHolder.score = ScoreManager.ReadScore();
            ScoreHolder.level = curLevel;
            SceneManager.LoadScene("GameOver");
            //GameOver
            //Debug.Log("GAME OVER");
        }
    }
}
