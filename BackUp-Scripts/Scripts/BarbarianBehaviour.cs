using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarianBehaviour : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float rotateSpeed = 3f;
    public float jumpSpeed = 10f;
    public float distanceToGround = 0.1f;
    public LayerMask groundLayer;
    private float vInput;
    private float hInput;
    private CapsuleCollider col;
    private Rigidbody rigidBody;
    public GameObject bullet;
    public float bulletspeed = 100f;

    void Start()
    {
        // Grab Rigid body component
        rigidBody = GetComponent<Rigidbody>();

        //Grab capsule collider
        col = GetComponent<CapsuleCollider>();

    }

    void Update()
    {
        // Get vertical key pressed and multiply with movespeed
        vInput = Input.GetAxis("Vertical") * moveSpeed;

        // Get horizontal key pressed and multiply with rotateSpeed
        hInput = Input.GetAxis("Horizontal") * rotateSpeed;


    }

    void FixedUpdate()
    {
        // Add what direction to rotation and store it in rotation
        Vector3 rotation = Vector3.up * hInput;

        // convert rotation to quaternion and store it
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);

        // apply rotation to rigidbody
        rigidBody.MoveRotation(rigidBody.rotation * angleRot);

        // apply position  to rigidbody
        rigidBody.MovePosition(this.transform.position + this.transform.forward * vInput * Time.fixedDeltaTime);

        //find out if space bar is pressed or not, this methods returns boolen value
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }

        if (Input.GetMouseButtonDown(0))
        {
            //Instantiate(prefab, new Vector3(i * 2.0F, 0, 0), Quaternion.identity);
            GameObject newBullet = Instantiate(bullet, this.transform.position + new Vector3(1,2,0),this.transform.rotation) as GameObject;
            Rigidbody bulletRB = newBullet.GetComponent<Rigidbody>();
            bulletRB.velocity = this.transform.forward * bulletspeed;
        }

    }
    
    private bool IsGrounded()
    {
        //finds the bottom of barbarian collider and store in capsuleBottom
        Vector3 capsuleBottom = new Vector3(col.bounds.center.x, col.bounds.min.y, col.bounds.center.z);


        bool grounded = Physics.CheckCapsule(col.bounds.center, capsuleBottom, distanceToGround, groundLayer, QueryTriggerInteraction.Ignore);
        return grounded;
    }
}
