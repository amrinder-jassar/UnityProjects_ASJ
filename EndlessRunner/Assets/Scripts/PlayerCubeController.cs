using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCubeController : MonoBehaviour
{
    //############## SIMPLE JUMP AND RIGht LEFT MOtion ###################
    float hInput;
    float vInput;
    public float moveSpeed;
    public float rotSpeed;
    public float jumpSpeed;
    public Rigidbody rb;
    bool canJump = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        hInput = Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime;
        vInput = Input.GetAxis("Vertical")*moveSpeed*Time.deltaTime;   
    }
    private void FixedUpdate()
    {
        rb.AddForce(hInput, 0f, vInput);
        if (Input.GetKeyDown("space") && canJump == true)
        {
            rb.AddForce(Vector3.up * jumpSpeed);
            canJump = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Plane" || collision.gameObject.name == "Ramp")
        {
            canJump = true;
        }
     }
  
}
