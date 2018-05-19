using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;

public class BlockColor : MonoBehaviour {

    public ColorX color;

    private Material blockMaterial;
    private Animation fadeAnimation;

	void Start () {

        fadeAnimation = GetComponent<Animation>();

        blockMaterial = GetComponent<Renderer>().material;
        switch (color)
        {
            case ColorX.red:
                blockMaterial.SetColor("_Color", Color.red);
                break;

            case ColorX.green:
                blockMaterial.SetColor("_Color", Color.green);
                break;

            case ColorX.blue:
                blockMaterial.SetColor("_Color", Color.blue);
                break;

            case ColorX.pink:
                blockMaterial.SetColor("_Color", Color.magenta);
                break;

            case ColorX.yellow:
                blockMaterial.SetColor("_Color", Color.yellow);
                break;

            case ColorX.cyan:
                blockMaterial.SetColor("_Color", Color.cyan);
                break;
            default:
                break;
        }
    }
	
    void OnCollisionEnter(Collision col) {
        if(col.gameObject.CompareTag("Player"))
        {
            ColorX playerColor = col.gameObject.GetComponent<PlayerMovement>().playerColor;
            if (playerColor == color)
            {
                fadeAnimation.Play();
                float t = fadeAnimation.clip.length;
                Destroy(gameObject, t);
            }
        }
    } 
}
