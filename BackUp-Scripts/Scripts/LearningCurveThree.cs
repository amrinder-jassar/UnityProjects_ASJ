using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurveThree : MonoBehaviour
{
    void Start()
    {
        // WHILE LOOP
        int playerLives = 3;
        while (playerLives > 0)
        {
            Debug.Log("Still Alive");
            playerLives--;
        }
        Debug.Log("Game Over");
    }
}
