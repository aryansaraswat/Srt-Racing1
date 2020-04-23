using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    public float carspeed;
    public float maxPos = 2.21f;
    public UIManager UI;
    Vector2 position;
    private Rigidbody2D rb;
    private float MoveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 1.27f)
                        rb.velocity = new Vector2(-MoveSpeed, 0f);

                    if (touch.position.x > Screen.width / 1.27f)
                        rb.velocity = new Vector2(MoveSpeed, 0f);
                    break;
                case TouchPhase.Ended:
                    rb.velocity = new Vector2(0f, 0f);
                    break;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy Car")
        {
            Destroy(gameObject);
            UI.gameOverActivated();
        }
    }
}
