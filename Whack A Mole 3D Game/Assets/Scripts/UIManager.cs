using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    public Text scoreText;

    void Awake()
    {
        instance = this;
        UpdateUI();
    }
    public void UpdateUI()
    {
        scoreText.text = "Score: "+ ScoreManager.ReadScore();
    }
}
