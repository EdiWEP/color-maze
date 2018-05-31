using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;

public class DestroyContactBlock : MonoBehaviour {

    private ColorX blockColor;
    private Animation fadeAnimation;

    void Start () {
        fadeAnimation = GetComponent<Animation>();
        blockColor = GetComponent<BlockColor>().color;
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            ColorX playerColor = col.gameObject.GetComponent<PlayerMovement>().playerColor;
            if (playerColor == blockColor)
            {
                fadeAnimation.Play();
                float t = fadeAnimation.clip.length;
                Destroy(gameObject, t);
            }
        }
    }
}
