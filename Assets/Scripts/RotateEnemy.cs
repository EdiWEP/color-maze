using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy : MonoBehaviour {

    private Vector3 rotator;
   
	void Start () {

        rotator.Set(30, 20, 40);     
    }
	
	void Update () {

        transform.Rotate(rotator * Time.deltaTime);

	}
}
