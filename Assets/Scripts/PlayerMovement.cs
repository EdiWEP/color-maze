using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ColorEnum;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public ColorX playerColor;
    public Text scoreText;
    public AudioClip gotCoin, changedColor, gunColorChange;

    private int groundMask;
    private int score = 0;
    private GunColor gunColor;
    private Material playerMaterial;
    private Rigidbody playerRB;
    Vector3 horizontal, vertical, movement;

	void Start () {
        groundMask = LayerMask.GetMask("Floor");
        playerRB = GetComponent<Rigidbody>();
        gunColor = GetComponentInChildren<GunColor>();

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

        Turn();
	}

    void Move() {

        Vector3 moveHorizontal = Input.GetAxisRaw("Horizontal") * horizontal;
        Vector3 moveVertical = Input.GetAxisRaw("Vertical") * vertical;
        movement = moveHorizontal + moveVertical;
        movement = movement.normalized * speed * Time.deltaTime;
        
        playerRB.AddForce(movement * 300);
        
    }

    void Turn()
    {
        Ray cameraRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit groundHit;

        if (Physics.Raycast(cameraRay, out groundHit, 100f, groundMask))
        {
            Vector3 playerToMouse = groundHit.point - transform.position;
            playerToMouse.y = 0.0f;
            Quaternion rotation = Quaternion.LookRotation(playerToMouse);
            playerRB.MoveRotation(rotation);
        }
    }

    void OnTriggerEnter(Collider col) {

        if(col.CompareTag("Coin"))
        {
            UpdateScore();

            AudioSource.PlayClipAtPoint(gotCoin, transform.position);

            Destroy(col.gameObject);
        }

        if(col.CompareTag("Color Pill"))
        {
            playerColor = col.gameObject.GetComponent<PillColor>().color;
            ChangeColor();

            AudioSource.PlayClipAtPoint(changedColor, transform.position);

            Destroy(col.gameObject);
        }

        if(col.CompareTag("Enemy"))
        {
            Die();
        }

        if(col.CompareTag("Gun Pill"))
        {
            gunColor.ChangeColor(col.gameObject.GetComponent<GunPillColor>().color);

            AudioSource.PlayClipAtPoint(gunColorChange, transform.position);

            Destroy(col.gameObject);
        }
    }

    void ChangeColor()
    {
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
    }
    
    void UpdateScore()
    {
        score += 100;
        GameManager.score += 100;
        scoreText.text = "Score: " + GameManager.score.ToString();
    }

    void Die()
    {
        GameManager.score -= score;
        GameManager.RestartLevel();
    }

    void OnCollisionEnter()
    {
        playerRB.velocity = Vector3.zero;
    }
}
