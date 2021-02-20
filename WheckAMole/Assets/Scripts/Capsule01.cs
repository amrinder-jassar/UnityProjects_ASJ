using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule01 : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        anim.SetTrigger("Active");
        if (Input.GetMouseButtonDown(0)&& gameObject.tag == "bait")
        {
            Destroy(gameObject);
        }
    }
}
