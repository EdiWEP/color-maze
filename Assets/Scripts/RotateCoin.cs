using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour {

    private Vector3 rotator;

	void Start () {
        rotator.Set(90, 0, 0);
	}
	
	
	void Update () {
        transform.Rotate(rotator*Time.deltaTime);
	}
}
