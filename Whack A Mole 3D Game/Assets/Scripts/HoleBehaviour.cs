using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehaviour : MonoBehaviour
{
    public GameObject[] moles;

    void Start()
    {
        Invoke("Spawn",Random.Range(3f,7f)); //Invoke Calls a method after specific amount of time.
    }
    void Spawn()
    {
        int num = Random.Range(0,moles.Length);
        GameObject mole = Instantiate(moles[num],transform.position, Quaternion.identity) as GameObject;
        Invoke("Spawn",Random.Range(3f,7f));
    }
}
