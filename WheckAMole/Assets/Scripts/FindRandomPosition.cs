using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRandomPosition : MonoBehaviour
{
    public List <Transform> locations;
    public Vector3 newPosition;
    public GameObject Capsule;

    private void Start()
    {
        InitializePopPositions();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = CallRandomPosition(locations);
            newPosition = locations[index].transform.position;
            Debug.Log(newPosition);
            Instantiate(Capsule, newPosition,Quaternion.identity);
        }
        
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