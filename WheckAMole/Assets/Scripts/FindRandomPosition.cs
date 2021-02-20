using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRandomPosition : MonoBehaviour
{
    public List <Transform> locations;
    public List<int> indexCheck;
    public Vector3 InstantiatePosition;
    public GameObject Capsule;

    private void Start()
    {
        InitializePopPositionsList();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = CallRandomPosition(locations);

            InstantiatePosition = locations[index].transform.position;
            Instantiate(Capsule, InstantiatePosition,Quaternion.identity);
        }
        
    }
    //####################################################################
    //           METHODS DECLARED AHEAD
    //####################################################################
    void InitializePopPositionsList()
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