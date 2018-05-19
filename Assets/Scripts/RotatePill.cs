using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePill : MonoBehaviour {

    private Vector3 rotator;

	void Start () {
        rotator.Set(30, 0, -45);	
	}
	
	
	void Update () {
        transform.Rotate(rotator * Time.deltaTime * 2);
	}
}
