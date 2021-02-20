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
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 newMousePos = Camera.main.ScreenToViewportPoint(mousePos);
            Debug.Log(mousePos);
            Debug.Log(newMousePos);
            Destroy(gameObject);
        }
    }
}
