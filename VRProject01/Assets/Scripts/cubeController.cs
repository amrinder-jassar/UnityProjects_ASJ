using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    public GameObject blastEffect;

    private void OnCollisionEnter(Collision collision)
    {
        
        Destroy(gameObject);
        Instantiate(blastEffect, this.transform.position, Quaternion.Euler(-90f,0f,0f));
        gameController01 updateScore = GameObject.Find("GameManager").GetComponent<gameController01>();
        updateScore.Score += 1;
        // above line is Updating score using setter from gameController01 script
    }
}
