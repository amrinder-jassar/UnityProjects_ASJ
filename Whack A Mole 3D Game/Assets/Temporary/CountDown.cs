using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    public void SetCountDown()
    {
        GameManager.instance.countDownDone = true;
        GameManager.instance.StartCoroutine("PlayTimer");
        this.gameObject.SetActive(false);

    }
}
