using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;


public class TeleporterColor : MonoBehaviour {

    public ColorX color;

    private Material teleporterMaterial;
	
	void Start () {

        teleporterMaterial = GetComponent<Renderer>().material;
        switch (color)
        {
            case ColorX.red:
                teleporterMaterial.SetColor("_Color", Color.red);
                break;

            case ColorX.green:
                teleporterMaterial.SetColor("_Color", Color.green);
                break;

            case ColorX.blue:
                teleporterMaterial.SetColor("_Color", Color.blue);
                break;

            case ColorX.pink:
                teleporterMaterial.SetColor("_Color", Color.magenta);
                break;

            case ColorX.yellow:
                teleporterMaterial.SetColor("_Color", Color.yellow);
                break;

            case ColorX.cyan:
                teleporterMaterial.SetColor("_Color", Color.cyan);
                break;
            default:
                break;
        }
    }
	
	
}
