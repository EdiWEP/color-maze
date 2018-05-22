using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;

public class EndPointColor : MonoBehaviour {

    public ColorX color;

    private Material pointMaterial;

    void Start()
    {
        pointMaterial = gameObject.GetComponent<Renderer>().material;
        switch (color)
        {
            case ColorX.red:
                pointMaterial.SetColor("_Color", Color.red);
                break;
            case ColorX.green:
                pointMaterial.SetColor("_Color", Color.green);
                break;

            case ColorX.blue:
                pointMaterial.SetColor("_Color", Color.blue);
                break;

            case ColorX.pink:
                pointMaterial.SetColor("_Color", Color.magenta);
                break;

            case ColorX.yellow:
                pointMaterial.SetColor("_Color", Color.yellow);
                break;

            case ColorX.cyan:
                pointMaterial.SetColor("_Color", Color.cyan);
                break;

            default:
                break;
        }
    }

}
