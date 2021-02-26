using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    public static void AddScore(int amount)
    {
        score += amount;
        Debug.Log("Current Score:" + score);
    }

    public int ReadScore()
    {
        return score;
    }
}
