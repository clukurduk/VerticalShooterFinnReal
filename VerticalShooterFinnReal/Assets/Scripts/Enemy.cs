using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public GameObject player;
    Vector3 playerPosition;
    [SerializeField] public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;
        playerPosition = player.transform.position;
        transform.position=Vector3.MoveTowards(transform.position,playerPosition, step);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PlayerHitBox"))
        {
            Destroy(this.gameObject);
        }
    }
}
