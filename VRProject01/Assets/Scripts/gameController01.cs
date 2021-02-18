using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController01 : MonoBehaviour
{
    public GameObject cubeObject;
    public float depthSet ;
    private int score = 0;
    public GameObject WinScreen;
    public int Score
    {
        get
        {
            return score;
        }
        set
        {
            score = value;
        }
    }
    void Update()
    {
      
        if (Input.GetMouseButtonDown(0) && score < 10 )
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = depthSet;
            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(mousePos);  
            Instantiate(cubeObject, spawnPos,Quaternion.identity);
            //score += 1;// score also updates on cube fall in cubeControlller script 
        }
        else if (Input.GetMouseButtonDown(0) && score >= 10)
        {
            WinScreen.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }
}
