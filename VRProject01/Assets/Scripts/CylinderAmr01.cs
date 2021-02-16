using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderAmr01 : MonoBehaviour
{
    List<string> Towers = new List<string>() { "tower1", "tower2", "tower3","towewr4"};

    private void Start()
    {
        
        for (int i=0; i<Towers.Count;i++)
        {
            //Debug.Log(Towers[i]);
        }
    }
}
