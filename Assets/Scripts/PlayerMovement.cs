using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ColorEnum;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public ColorX playerColor;
    public Text scoreText;
    public AudioClip gotCoin;
    public AudioClip changedColor;

    private int score = 0;
    private Material playerMaterial;
    //private Rigidbody playerRB;
    Vector3 horizontal, vertical, movement;

	void Start () {
        //playerRB = GetComponent<Rigidbody>();
        vertical = Camera.main.transform.forward;
        vertical.y = 0.0f;
        vertical.Normalize();
        horizontal = Quaternion.Euler(new Vector3(0, 90, 0)) * vertical;

        playerMaterial = GetComponent<Renderer>().material;
	}

	void FixedUpdate () {

        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical")) {
            Move();
        }
	}

    void Move() {

        Vector3 moveHorizontal = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime * horizontal;
        Vector3 moveVertical = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime * vertical;

        transform.position += moveHorizontal + moveVertical;
        if(Input.GetButton("Horizontal") && Input.GetButton("Vertical"))
        {
            transform.position -= (moveHorizontal + moveVertical) * 0.3f;
        }
    }

    void OnTriggerEnter(Collider col) {

        if(col.CompareTag("Coin"))
        {
            score += 100;
            scoreText.text = "Score: " + score.ToString();
            AudioSource.PlayClipAtPoint(gotCoin, transform.position);

            Destroy(col.gameObject);
        }

        if(col.CompareTag("Color Pill"))
        {
            playerColor = col.gameObject.GetComponent<PillColor>().color;
            
            switch (playerColor)
            {
                case ColorEnum.ColorX.red:
                    playerMaterial.SetColor("_Color", Color.red);
                    break;
                case ColorEnum.ColorX.green:
                    playerMaterial.SetColor("_Color", Color.green);
                    break;
                case ColorEnum.ColorX.blue:
                    playerMaterial.SetColor("_Color", Color.blue);
                    break;
                case ColorEnum.ColorX.pink:
                    playerMaterial.SetColor("_Color", Color.magenta);
                    break;
                case ColorEnum.ColorX.yellow:
                    playerMaterial.SetColor("_Color", Color.yellow);
                    break;
                case ColorEnum.ColorX.cyan:
                    playerMaterial.SetColor("_Color", Color.cyan);
                    break;
                default:
                    break;
            }

            AudioSource.PlayClipAtPoint(changedColor, transform.position);
            Destroy(col.gameObject);
        }

        if(col.CompareTag("Enemy"))
        {
            
        }
    }
}
