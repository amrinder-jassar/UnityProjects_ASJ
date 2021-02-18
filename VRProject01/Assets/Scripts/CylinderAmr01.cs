using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderAmr01 : MonoBehaviour
{
    void FixedUpdate()
    {
        RaycastHit hit;
        int layerMask = 0;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100f, Color.yellow);
        //Debug.LogFormat("hit value is:{0}", hit.distance);

    }
}
