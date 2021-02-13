using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCubeController : MonoBehaviour
{
    //############## SIMPLE JUMP AND RIGht LEFT MOtion 2 VR concept start ###################
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
        if (Input.GetKey("up"))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey("right"))
        {
            transform.RotateAround(transform.position, Vector3.up, rotSpeed * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            transform.RotateAround(transform.position, Vector3.up, -rotSpeed * Time.deltaTime);
        }
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
