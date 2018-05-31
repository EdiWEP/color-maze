using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;

public class DestroyGunBlock : MonoBehaviour {

    public GameObject explosion;

    private ColorX blockColor;
    private AudioSource audioSource;

	void Start() {
        blockColor = GetComponent<BlockColor>().color;
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.CompareTag("Bullet"))
        {
            if(col.gameObject.GetComponent<BulletColor>().color == blockColor)
            {
                Vector3 pos = transform.position;
                pos.y = 0f;
                GameObject explosionInstance = Instantiate(explosion, pos, transform.rotation) as GameObject;
                audioSource.Play();
                Destroy(col.gameObject);
                Destroy(gameObject,0.8f);
                Destroy(explosionInstance, 1.25f);
            }
        }
    }
}
