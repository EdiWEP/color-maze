using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;

public class GunPillColor : MonoBehaviour {

    public ColorX color;
    public Renderer cube1Renderer, cube2Renderer;

    private Material cube1Mat, cube2Mat;
    
	void Start () {

        cube1Mat = cube1Renderer.material;
        cube2Mat = cube2Renderer.material;

        switch (color)
        {
            case ColorX.red:
                cube1Mat.SetColor("_Color", Color.red);
                cube2Mat.SetColor("_Color", Color.red);
                break;

            case ColorX.green:
                cube1Mat.SetColor("_Color", Color.green);
                cube2Mat.SetColor("_Color", Color.green);
                break;

            case ColorX.blue:
                cube1Mat.SetColor("_Color", Color.blue);
                cube2Mat.SetColor("_Color", Color.blue);
                break;

            case ColorX.pink:
                cube1Mat.SetColor("_Color", Color.magenta);
                cube2Mat.SetColor("_Color", Color.magenta);
                break;

            case ColorX.yellow:
                cube1Mat.SetColor("_Color", Color.yellow);
                cube2Mat.SetColor("_Color", Color.yellow);
                break;

            case ColorX.cyan:
                cube1Mat.SetColor("_Color", Color.cyan);
                cube2Mat.SetColor("_Color", Color.cyan);
                break;

            default:
                break;
        }
    }
	
}
