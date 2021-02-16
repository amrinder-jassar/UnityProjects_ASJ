using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderAmr01 : MonoBehaviour
{
    //########## Creating and filling in ARRAYS #############
    public GameObject[] Towers;
    private void Start()
    {
        Towers = GameObject.FindGameObjectsWithTag("Tower");
        for(int i=0; i<Towers.Length; i++)
        {
            Debug.Log("Tower no "+i+" has name"+Towers[i]);
            Debug.LogFormat("Z");
        }
    }
}
