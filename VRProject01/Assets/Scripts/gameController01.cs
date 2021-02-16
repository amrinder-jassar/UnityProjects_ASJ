using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController01 : MonoBehaviour
{
    public GameObject cubeObject;
    public float depthSet ;
    void Update()
    {
      
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = depthSet;
            Vector3 spawnPos = Camera.main.ScreenToWorldPoint(mousePos);  
            Instantiate(cubeObject, spawnPos,Quaternion.identity);
        }
        
    }
}
