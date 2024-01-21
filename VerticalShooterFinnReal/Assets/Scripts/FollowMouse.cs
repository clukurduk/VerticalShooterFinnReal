using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField] private Rigidbody2D anchor;
    

    private void Update()
    {


        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        worldPosition.z = 0;


        Vector3 Rotation = anchor.transform.position - worldPosition;
        float rotationZ = Mathf.Atan2(Rotation.y, Rotation.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotationZ + 90);
    }


}
