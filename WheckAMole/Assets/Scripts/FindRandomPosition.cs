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
            int no = Random.Range(0,8);

            if(IndexCheck.Count >=0 && IndexCheck.Count <=8)
            {
                IndexCheck.Add(no);
                for (int i = 0; i < IndexCheck.Count; i++)
                {
                    if (no == IndexCheck[i])
                    {
                        Debug.Log("This No Already Exist in LIst, DO Nothing");
                    }
                    else if(no != IndexCheck[i])
                    {
                        IndexCheck.Add(no);
                        Debug.Log("This No is not in List and is ADDED");
                    }
                }

                       
            }
            else
            {                
                IndexCheck.RemoveAt(0);
            }


            for (int y =0;y<IndexCheck.Count;y++)
            {
                Debug.Log(IndexCheck[y]);
            }
            Debug.LogFormat("LIST COUNT IS:{0}",IndexCheck.Count);
            Vector3 SpawnPos =  locations[no].transform.position;
            Instantiate(Capsule,SpawnPos,Quaternion.identity);
        }
        
    }
   
}