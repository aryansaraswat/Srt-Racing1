using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Player : MonoBehaviour
{
     float carspeed = 20f;
    public float maxPos = 1.9f;
    public UIManager UI;
    Vector2 position;
    private Rigidbody2D rb;
   private float moveSpeed = 25f;
    float dirX;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        position.x += Input.GetAxis("Horizontal") * carspeed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.21f, 2.21f);
        transform.position = position;
    }

    /*{ dirX = Input.acceleration.x * moveSpeed;
     transform.position = new Vector2(Mathf.Clamp(transform.position.x, -1.9f, 1.9f), transform.position.y);
 }*/
 void FixedUpdate()
 {
     rb.velocity = new Vector2(dirX, 0f);
 }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy Car")
        {
            Destroy(gameObject);
            UI.gameOverActivated();
        }
      if(col.gameObject.tag =="Coin")
        {
            Destroy(col.gameObject);
            UI.IncreaseCoins();
        }
    }
}
