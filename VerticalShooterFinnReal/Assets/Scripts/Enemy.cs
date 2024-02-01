using System.Collections;
using System.Collections.Generic;
using System.Data;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    Vector3 playerPosition;
    [SerializeField] public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        playerPosition = player.transform.position;
        transform.position=Vector3.MoveTowards(transform.position,playerPosition, step);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
 

        if (other.gameObject.CompareTag("Player"))
        {
            sceneSwap();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {


        if (other.gameObject.CompareTag("PlayerHitBox"))
        {
            Destroy(gameObject);
        }
    }

    void sceneSwap()
    {

    }
}
