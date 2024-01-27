using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SpawnHitbox : MonoBehaviour
{
    private Ray ray;
    private Vector3 spawnPoint;
    [SerializeField] private float distanceFromPlayer;
    [SerializeField] GameObject swordHitBox;
    [SerializeField] GameObject anchor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("mouse 0"))
        {
            ray = new Ray(transform.position, Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position);
            spawnPoint = ray.GetPoint(distanceFromPlayer);

            //Quaternion rot = Quaternion.Euler(ray.direction.x, ray.direction.y, ray.direction.z);
            //Debug.Log(rot);

            GameObject go = Instantiate(swordHitBox, spawnPoint, Quaternion.identity);
            go.transform.up = new Vector3(ray.direction.x, ray.direction.y, 0.0f);


        }
    }
}
