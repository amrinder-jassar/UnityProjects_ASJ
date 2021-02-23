using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehaviour : MonoBehaviour
{
    Collider col;

    private void Start()
    {
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
        //Any other no except for 0 is going to reyturn true, but 0 is return false.
    }
}
