using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurveTwo : MonoBehaviour
{
    void Start()
    {
        // DICTIONARIES
        //Creating a Dictionary
        Dictionary<string, int> gurdwaraLanger = new Dictionary<string, int>(){{"Rotties",4},{"Sabji",3},{"Kheer",1}};
        Debug.LogFormat("Total no of eatables: {0}", gurdwaraLanger.Count);

        //First way to add to dictionary
        gurdwaraLanger.Add("Daal",4);
        Debug.LogFormat("Total no of eatables after addition: {0}", gurdwaraLanger.Count);

        //Second better way to add to dictionary is using ContainKey pair
        if (gurdwaraLanger.ContainsKey("Kheer"))
        {
            gurdwaraLanger["Kheer"] = 2;
            Debug.Log("there are two Kheers now");
        }
        else
        {
            Debug.Log("Eatable not found");
        }

        //Removing from dictionary
        gurdwaraLanger.Remove("Kheer");
        Debug.Log("Kheer is now Removed");
        Debug.LogFormat("Total no of eatables after removing kheer: {0}", gurdwaraLanger.Count);
    }
}
