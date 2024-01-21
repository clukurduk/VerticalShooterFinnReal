using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Attacking : MonoBehaviour
{
    [SerializeField] private GameObject swordHitbox;
    [SerializeField] private GameObject anchor;

    Vector3 anchorPos;
    Quaternion anchorRot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() 
    {
        //instantiates hitbox from anchors location
        if(Input.GetKeyDown("mouse 0"))
        {
            anchorPos=anchor.transform.position;
            anchorRot = anchor.transform.rotation;
            
            //Instantiate(swordHitbox, new Vector3(0,2,0), anchorRot, anchor);
        }
    }
}
