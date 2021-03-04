using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int playtime = 10;//TIMER
    int seconds, minutes;
    public static int curLevel = 1;//LEVEL & SCORE
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
    }
    IEnumerator PlayTimer()// IEnumerator is Time Based Function & return something
    {
        while (playtime > 0)
        {
            yield return new WaitForSeconds(1);
            playtime--;
            seconds = playtime % 60;
            minutes = playtime / 60 % 60;
            UIManager.instance.UpdateTime(minutes,seconds);//Update UI
        }
        CheckForWin();// WIN Condition
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
        }
    }
}