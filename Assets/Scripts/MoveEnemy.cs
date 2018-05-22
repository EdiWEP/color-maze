using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {

    public float speed;
    public bool startRightForward;
    public bool xAxis;
    public Vector3 firstDistance;
    public Vector3 secondDistance;

    private float currentDist;
    private float totalDist;
    private float fraction;
    private bool forward;
    private Vector3 startPosition;
    private Vector3 firstPosition;
    private Vector3 secondPosition;

	void Start () {
        forward = startRightForward;

        startPosition = transform.position;
        firstPosition = startPosition + firstDistance;
        secondPosition = startPosition + secondDistance;

        if (xAxis)
        {
            currentDist = startPosition.x - firstPosition.x;
            totalDist = secondPosition.x - firstPosition.x;
        }
        else
        {
            currentDist = startPosition.z - firstPosition.z;
            totalDist = secondPosition.z - firstPosition.z;
        }
	}
	
	void FixedUpdate () {
        Patrol();
	}

    void Patrol()
    {
        fraction = currentDist / totalDist;
        transform.position = Vector3.Lerp(firstPosition, secondPosition, fraction);
        if (forward)
        {
            currentDist += Time.deltaTime * speed;
            if (currentDist > totalDist)
            {
                forward = false;
                currentDist = totalDist;
            }
        }
        else
        {
            currentDist -= Time.deltaTime * speed;
            if (currentDist < 0.0f)
            {
                forward = true;
                currentDist = 0.0f;
            }
        }
    }
}
