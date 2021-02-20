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
            int index = Random.Range(0, 9);
            for (int i=0;i<9;i++)
            {
                if (indexCheck.Count==0)
                {
                    indexCheck.Add(index);
                    Debug.Log("Count ZERO");
                }
                else if (index == indexCheck[i])
                {
                    Debug.Log("Already Exist in LIST");
                }
                else if (index != indexCheck[i])
                {
                    indexCheck.Add(index);
                    PrintList(indexCheck);
                }
            }
            
        }
                        
            //InstantiatePosition = locations[index].transform.position;
            //Instantiate(Capsule, InstantiatePosition,Quaternion.identity);
        
        
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

    void PrintList(List<int>listName)
    {
        Debug.Log("PRINTING LIST");
        for (int index = 0; index < listName.Count;index++)
        {
            Debug.Log(listName[index]);
        }
    } 
   
}