using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;


public class PillColor : MonoBehaviour {

    public ColorX color;
    private Material pillMaterial;
	void Start () {

        pillMaterial = GetComponent<Renderer>().material;

        switch (color)
        {
            case ColorX.red:
                pillMaterial.SetColor("_Color", Color.red);                        
                break;

            case ColorX.green:
                pillMaterial.SetColor("_Color", Color.green);
                break;

            case ColorX.blue:
                pillMaterial.SetColor("_Color", Color.blue);
                break;

            case ColorX.pink:
                pillMaterial.SetColor("_Color", Color.magenta);
                break;

            case ColorX.yellow:
                pillMaterial.SetColor("_Color", Color.yellow);
                break;

            case ColorX.cyan:
                pillMaterial.SetColor("_Color", Color.cyan);
                break;

            default:
                break;
        }
    }
	
}
