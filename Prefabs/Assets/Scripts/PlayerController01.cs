using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController01 : MonoBehaviour
{
    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bulletObject = Instantiate(Bullet);
            BulletController01 bullet = bulletObject.GetComponent<BulletController01>();
            bullet.shootingDirection = Vector3.forward;
        }
    }
}
