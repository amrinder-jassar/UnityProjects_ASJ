using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionStat : MonoBehaviour
{
    public string firstName;
    public bool hasDungeonKey;
    // Start is called before the first frame update
    void Start()
    {
        if (firstName == "Amrinder")
        {
            Debug.LogFormat("{0} is Animator", firstName);
        }
        else if (firstName == "Jaskaran")
        {
            Debug.LogFormat("{0} is IT Professional", firstName);
        }
        else 
        {
            Debug.Log("Name not in list");
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
