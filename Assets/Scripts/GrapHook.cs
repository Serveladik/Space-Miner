using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapHook : MonoBehaviour
{
 public float speed;
     public float rotateRate;
 
     private Vector3 mouseWorldPos;
     private Vector3 moveDirection;
     private bool isActive;
 
     private void Update()
     {
         if (Input.GetMouseButtonDown(0) && !isActive)
         {
             // make it active right away to stop the player from adding more inputs.
             isActive = true;
             Vector3 mouseScreenPos = Input.mousePosition;
             mouseScreenPos.z = 20f;
             mouseWorldPos = Camera.main.ScreenToWorldPoint(mouseScreenPos);
 
             // Get the normalized direction -> targetPos - playerPos.
             // normalized to ensure that it will always move at the same speed.
             moveDirection = (mouseWorldPos - transform.position).normalized;
             moveDirection.z = 0f;
         }
 
     }
     void FixedUpdate()
     {
         if (isActive)
         {
             // Use this line if you want your player to look towards the direction
             // change to transform.right if you want to update the x axis
             // you can also invert it by simply changing the plus (+) to a minus (-)
             // transform.up += moveDirection * Time.deltaTime * rotateRate;
             transform.position += moveDirection * Time.deltaTime * speed;
         }
     }
    void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Rock")
        {
            Debug.Log(isActive);
            isActive=false;
        }
    }
}

