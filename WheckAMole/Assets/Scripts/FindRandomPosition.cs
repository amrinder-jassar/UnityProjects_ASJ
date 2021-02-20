using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRandomPosition : MonoBehaviour
{
    public List <Transform> locations;
    public Vector3 newPosition;

    private void Start()
    {
        InitializePopPositions();
    }

    void Update()
    {
        int index = CallRandomPosition(locations);
        Debug.Log(index);
    }




    //####################################################################
    //           METHODS DECLARED AHEAD
    //####################################################################
    void InitializePopPositions()
    {
        Transform popPositions = GameObject.Find("PopPositions").transform;
        foreach (Transform child in popPositions)
        {
            locations.Add(child);
        }
        
    }
    //##################################################################
    public int CallRandomPosition(List<Transform>listName)
    {
        int i = Random.Range(0, listName.Count);
        return i;
    }
}