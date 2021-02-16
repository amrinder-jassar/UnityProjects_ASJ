using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleClass : MonoBehaviour
{
    //################### HOW TO USE RAYCAST #################
    void FixedUpdate()
    {

        LayerMask mask = LayerMask.GetMask("plane");
        RaycastHit hit;
        Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, mask);
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
        Debug.Log(hit.distance);
    }
}