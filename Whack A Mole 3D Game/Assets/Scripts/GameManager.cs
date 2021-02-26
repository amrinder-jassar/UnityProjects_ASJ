using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int playtime = 60;
    int seconds, minutes;
    private void Awake()
    {
        StartCoroutine("PlayTimer");//passing name of PlayTimer Function
    }

    void Start()
    {
        StartCoroutine("PlayTimer");//passing name of PlayTimer Function
        
    }

    // IEnumerable is Time Based Function and going to return something
    IEnumerable PlayTimer()
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
    }
}
