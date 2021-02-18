using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Vector3 camOffset = new Vector3(0.5f,3.0f,-4f);
    public Transform target;

    void Start()
    {
        target = GameObject.Find("Player").transform ;
        
    }

    void LateUpdate()
    {
        Vector3 targetPosOffset = target.position + new Vector3(0f, 1.2f, 0f);
        this.transform.position = target.TransformPoint(camOffset);
        this.transform.LookAt(targetPosOffset);
    }
}
