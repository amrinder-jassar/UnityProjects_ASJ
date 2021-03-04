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
            //Invoke Calls a method after specific amount of time.
            Invoke("Spawn", Random.Range(0f, 7f));             
        }
    }
    void Spawn()
    {
        if (!hasMole && GameManager.instance.countDownDone)
        {
            //int num = Random.Range(0, moles.Length);
            int num = CalculateRarity();

            GameObject mole = Instantiate(moles[num], transform.position, Quaternion.identity) as GameObject;
            MoleBehaviour moleB = mole.GetComponent<MoleBehaviour>();
            moleB.myParent = this.gameObject;
            moleB.score = moleB.score * GameManager.curLevel;
            mole.GetComponent<MoleBehaviour>().myParent = this.gameObject;
            hasMole = true;
        }
        Invoke("Spawn", Random.Range(0f, 7f));
    }
    int CalculateRarity()
    {
        int num = Random.Range(0, 101);
        if (num <= 2)
        {
            return 4;//golden mole at index 4 in array
        }
        else if (num<=10)
        {
            return 3;// Time mole is at no 3
        }
        else if (num<=20)
        {
            return 2;
        }
        else if (num <= 50)
        {
            return 1;
        }
        return 0;// Zero would spawn first mole in list.
    }
}
