using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;
public class EndLevel : MonoBehaviour {

    private ColorX color;
    private ColorX playerColor;
    
    void Start()
    {
        color = gameObject.GetComponent<EndPointColor>().color;
    }
    
	void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Player"))
        {
            playerColor = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().playerColor;

            if (color == playerColor)
            {
                GameManager.NextLevel();
            }
        }
    }
	
}
