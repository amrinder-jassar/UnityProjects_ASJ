using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehaviour : MonoBehaviour
{
    public GameObject[] moles;
    public bool hasMole;

    void Start()
    {
        if (!hasMole)
        {
            Invoke("Spawn", Random.Range(0f, 7f)); //Invoke Calls a method after specific amount of time.
        }
    }
    void Spawn()
    {
        if (!hasMole)
        {
            int num = Random.Range(0, moles.Length);
            GameObject mole = Instantiate(moles[num], transform.position, Quaternion.identity) as GameObject;
            mole.GetComponent<MoleBehaviour>().myParent = this.gameObject;
            hasMole = true;
        }
        Invoke("Spawn", Random.Range(0f, 7f));
    }
}
