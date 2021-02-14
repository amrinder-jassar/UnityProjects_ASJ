using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController01 : MonoBehaviour
{
    public Rigidbody rb;
    public float bulletSpeed = 10f;
    public Vector3 shootingDirection;


    void Start()
    {
        GetComponent<Rigidbody>().AddForce(shootingDirection*bulletSpeed);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
