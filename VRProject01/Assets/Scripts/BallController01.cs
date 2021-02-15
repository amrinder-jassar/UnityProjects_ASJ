using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController01 : MonoBehaviour
{
    Rigidbody rb;
    float vInput;
    float hInput;
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        vInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        hInput = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        rb.AddForce(hInput, 0f, vInput);
    }    
}
