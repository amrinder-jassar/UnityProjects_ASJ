using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public Text scoreText;
    public Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Your Score : "+ ScoreHolder.score;
        levelText.text = "Your Level : "+ ScoreHolder.level;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Level01");
        }
    }
}
