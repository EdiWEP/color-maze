using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollisions : MonoBehaviour {


    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Wall") || col.CompareTag("Contact Block") || col.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }

}
