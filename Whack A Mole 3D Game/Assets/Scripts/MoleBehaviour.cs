using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehaviour : MonoBehaviour
{
    Collider col;
    [HideInInspector] public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        col = GetComponent<Collider>();
        col.enabled = false;
    }
    public void DestroyObj()
    {
        Destroy(gameObject);
    }
    public void SwitchCollider(int num)
    {
        col.enabled = (num == 0) ? false : true;
        //Any other number except for 0 is going to return true, but 0 is returning false.
    }
    //FOR POINTS LATER
    public void GotHit()
    {
        Destroy(gameObject);
    }
}
