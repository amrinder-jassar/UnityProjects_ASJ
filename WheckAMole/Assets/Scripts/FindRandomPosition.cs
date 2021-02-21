using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRandomPosition : MonoBehaviour
{
    public List <Transform> locations;
    public List<int> IndexCheck;
    public Vector3 InstantiatePosition;
    public GameObject Capsule;

    
    

    private void Start()
    {
        Transform popPositions = GameObject.Find("PopPositions").transform;
        foreach (Transform child in popPositions)
        {
            locations.Add(child);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
        
    }
}