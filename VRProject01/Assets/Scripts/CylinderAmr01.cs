using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderAmr01 : MonoBehaviour
{
    public float[] myHeight = {1.1f,2.2f,3.3f,4.4f,5.5f };
    void Start()
    {
        
        for(int i =0; i <4; i++)
        {
            Debug.Log(myHeight[i]);
        }
    }
}
