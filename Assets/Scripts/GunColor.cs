using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;

public class GunColor : MonoBehaviour {

    public ColorX gunColor;
    public bool isActive;

    private Material gunMaterial;
    

	void Start () {
        isActive = false;
        gunMaterial = GetComponent<Renderer>().material;
	}
	
	public void ChangeColor(ColorX color)
    {
        gunColor = color;
        isActive = true;
        switch (color)
        {
            case ColorX.red:
                gunMaterial.SetColor("_Color", Color.red);
                break;

            case ColorX.green:
                gunMaterial.SetColor("_Color", Color.green);
                break;

            case ColorX.blue:
                gunMaterial.SetColor("_Color", Color.blue);
                break;

            case ColorX.pink:
                gunMaterial.SetColor("_Color", Color.magenta);
                break;

            case ColorX.yellow:
                gunMaterial.SetColor("_Color", Color.yellow);
                break;

            case ColorX.cyan:
                gunMaterial.SetColor("_Color", Color.cyan);
                break;

            default:
                break;
        }
    }
}
