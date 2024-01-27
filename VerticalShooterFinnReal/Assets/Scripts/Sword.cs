using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField]int goal;
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
        if (count >= goal)
        {

            Object.Destroy(this.gameObject);
        }
        Debug.Log(count);
    }
}
