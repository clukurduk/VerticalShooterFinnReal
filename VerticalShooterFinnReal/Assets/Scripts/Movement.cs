using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{

    public Rigidbody2D rb;
    public float xDirection = 0f, yDirection = 0f;
    [SerializeField] float speed = 7.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxis("Horizontal");
        if (xDirection > 0f)
        {
            rb.velocity = new Vector2(xDirection * speed, rb.velocity.y);
        }
        else if (xDirection < 0f)
        {
            rb.velocity = new Vector2(xDirection * speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        yDirection = Input.GetAxis("Vertical");
        if (yDirection > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, yDirection * speed);
        }
        else if (yDirection < 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, yDirection * speed);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }
}