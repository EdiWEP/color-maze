using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;

public class EnemyColor : MonoBehaviour {

    public ColorX color;

    private Material mainSphereMaterial;

    void Start () {
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
		
}
