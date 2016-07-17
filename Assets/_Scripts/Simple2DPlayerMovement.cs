using UnityEngine;
using System.Collections;

public class Simple2DPlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;

    public float maxSpeed = 10.0f;
    public float jumpForce = 200.0f;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(move * maxSpeed, rb2d.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            rb2d.AddForce(new Vector2(0, jumpForce));
    }

}
