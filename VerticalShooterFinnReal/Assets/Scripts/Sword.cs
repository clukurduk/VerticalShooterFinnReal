using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField]int despawnGoal;
    private int count;
    // Start is called before the first frame update
    void Awake()
    {
        
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        count++;
        if (count >= despawnGoal)
        {
            
            Object.Destroy(this.gameObject);
        }
    }
}
