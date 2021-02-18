using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float onscreenDelay = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, onscreenDelay);
    }
}
