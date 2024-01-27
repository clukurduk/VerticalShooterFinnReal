using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Movement : MonoBehaviour
{
    //movement variables
    public bool moveable;
    public Rigidbody2D rb;
    public float xDirection = 0f, yDirection = 0f;
    [SerializeField] float speed = 7.5f;
    //spawnhitbox variables
    private Ray ray;
    private Vector3 spawnPoint;
    [SerializeField] private float distanceFromPlayer;
    [SerializeField] GameObject swordHitBox;
    [SerializeField] GameObject anchor;
    GameObject go;
    int count, current;

    // Start is called before the first frame update


    void Start()
    {
        count = 0;
        moveable = true;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        count++;


        if (!moveable)
        {
            speed = 0f;

        }
        else if (moveable)
        {
            speed = 3.5f;

        }
        

        

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


        //spawn hitbox script
        if (Input.GetKeyDown("mouse 0"))
        {
            //ray = new Ray(transform.position, Vector3.Normalize(Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position));

            Vector3 direction = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
            direction.z = 0;
            direction.Normalize();
            spawnPoint = transform.position + direction * distanceFromPlayer;

            //Quaternion rot = Quaternion.Euler(ray.direction.x, ray.direction.y, ray.direction.z);
            //Debug.Log(rot);

            go = Instantiate(swordHitBox, spawnPoint, Quaternion.identity);
            go.transform.up = direction;


        }

        if(go != null)
        {
            moveable = false;
        }
        else
        {
            moveable = true;
        }
    }

       
}