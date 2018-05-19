using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;

public class RotateEnemy : MonoBehaviour {

    public ColorX color;

    private Vector3 rotator;
    private Material mainSphereMaterial;
    

	void Start () {

        rotator.Set(30, 20, 40);
        mainSphereMaterial = gameObject.GetComponentInChildren<Renderer>().material;
        switch (color)
        {
            case ColorX.red:
                mainSphereMaterial.SetColor("_Color", Color.red);
                break;
            case ColorX.green:
                mainSphereMaterial.SetColor("_Color", Color.green);
                break;

            case ColorX.blue:
                mainSphereMaterial.SetColor("_Color", Color.blue);
                break;

            case ColorX.pink:
                mainSphereMaterial.SetColor("_Color", Color.magenta);
                break;

            case ColorX.yellow:
                mainSphereMaterial.SetColor("_Color", Color.yellow);
                break;

            case ColorX.cyan:
                mainSphereMaterial.SetColor("_Color", Color.cyan);
                break;

            default:
                break;
        }
    }
	
	void Update () {

        transform.Rotate(rotator * Time.deltaTime);

	}
}
