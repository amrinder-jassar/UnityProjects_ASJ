using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit))
            {
                if (hit.collider.tag == "Mole")
                {
                    MoleBehaviour mole = hit.collider.gameObject.GetComponent<MoleBehaviour>();
                    mole.SwitchCollider(0);// Disable collider
                    mole.anim.SetTrigger("hit");
                    //Debug.Log(hit.collider.gameObject + "got hit");
                }
            }
        }
    }
}