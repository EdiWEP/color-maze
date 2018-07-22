using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;

public class TeleportPlayer : MonoBehaviour {

    public GameObject otherTeleporter;
    public int numberOfTeleporters;

    private ColorX teleporterColor;
    private static float delay;
    private Vector3 otherTeleporterPosition;
    
    void Awake ()
    {
        delay = 1.0f;
    }

	void Start () {

        teleporterColor = GetComponent<TeleporterColor>().color;
        otherTeleporterPosition = otherTeleporter.transform.position;
        otherTeleporterPosition.y += 0.7f;
    }
	
	void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player") && delay == 1.0f)
        {
            if (col.GetComponent<PlayerMovement>().playerColor == teleporterColor)
            {
                delay = 0.0f;
                col.transform.position = otherTeleporterPosition;
            }
        }
    }

    void Update ()
    {
        if (delay < 1.0f)
        {
            delay += (Time.deltaTime / numberOfTeleporters);
        }
        if (delay > 1.0f)
        {
            delay = 1.0f;
        }
    }
}
