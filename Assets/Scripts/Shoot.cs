using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorEnum;

public class Shoot : MonoBehaviour {

    public GameObject projectile;
    public Transform gunEnd;
    public AudioClip gunSound;

    private GunColor gunColorScript;
    private float fireRate,timer;

	void Start () {
        fireRate = 0.65f;
        timer = 0.65f;
        gunColorScript = GetComponent<GunColor>();
	}
	
	
	void Update () {

        timer += Time.deltaTime;
		if(Input.GetButtonDown("Fire1") && timer >= fireRate)
        {
            timer = 0f;
            if (gunColorScript.isActive)
            {
                ShootBullet();
            }
        }
	}

    void ShootBullet()
    {
        AudioSource.PlayClipAtPoint(gunSound, transform.position);
        GameObject projectileInstance;
        projectileInstance = Instantiate(projectile, gunEnd.position, gunEnd.rotation) as GameObject;
        projectileInstance.GetComponent<BulletColor>().color = gunColorScript.gunColor;

        Material projectileMaterial = projectileInstance.GetComponent<Renderer>().material;
        Rigidbody bulletRB = projectileInstance.GetComponent<Rigidbody>();
        

        switch (gunColorScript.gunColor)
        {
            case ColorX.red:
                projectileMaterial.SetColor("_Color", Color.red);
                break;

            case ColorX.green:
                projectileMaterial.SetColor("_Color", Color.green);
                break;

            case ColorX.blue:
                projectileMaterial.SetColor("_Color", Color.blue);
                break;

            case ColorX.pink:
                projectileMaterial.SetColor("_Color", Color.magenta);
                break;

            case ColorX.yellow:
                projectileMaterial.SetColor("_Color", Color.yellow);
                break;

            case ColorX.cyan:
                projectileMaterial.SetColor("_Color", Color.cyan);
                break;

            default:
                break;
        }

        bulletRB.AddForce(gunEnd.forward * 500);
    }
}
