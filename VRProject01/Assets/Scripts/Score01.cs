using UnityEngine;
using UnityEngine.UI;

public class Score01 : MonoBehaviour
{
    public Text scoreText;
    void Update()
    {
        gameController01 currentScore = GameObject.Find("GameManager").GetComponent<gameController01>();
        scoreText.text = currentScore.Score.ToString();
        // above line is Reading score using Getter from gameController01 script
    }
}
