using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerBehaviour : MonoBehaviour
{
    public GameObject capsuleObj;
    
    void Start()
    {
        
        //###################  HOW TO PRINT ROTATAIONS & RANDON NUMBERS ###########
        Debug.LogFormat("Printing Euler Angles:{0}",transform.eulerAngles);// World Rotations
        Debug.LogFormat("Printing Local Euler Angles:{0}", transform.localEulerAngles);// Local Rotations

        for (int i = 0; i < 10; i++)
        {   
            GameObject myObj = Instantiate(capsuleObj);
            myObj.transform.position = new Vector3(i*2f, 1f, 1f);
            myObj.transform.localScale = new Vector3(Random.Range(-5f,5f),i*1f,1f);
        }

    }
}
