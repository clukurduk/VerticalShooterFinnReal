using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField]int despawnGoal;
    [SerializeField] int spawnGoal;
    private int count;
    [SerializeField] Collider2D yo;
    [SerializeField] SpriteRenderer sprite;
    // Start is called before the first frame update
    void Awake()
    {
        sprite= GetComponent<SpriteRenderer>();
        yo = GetComponent<Collider2D>();
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        count++;
        if(count >= spawnGoal)
        {
            yo.enabled=true;
            sprite.enabled = true;
        }
        if (count >= despawnGoal)
        {
            
            Object.Destroy(this.gameObject);
        }
    }
}
