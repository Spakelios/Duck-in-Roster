using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DucklingMovement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    private float horizontalInput;
    private void FixedUpdate()
    {
        
       
        Vector3 forwardMove = transform.forward * (speed * Time.fixedDeltaTime);
        Vector3 horizontalMove = transform.right * (horizontalInput * speed * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
        
    }
    
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x =  Mathf.Clamp(transform.position.x, -9f, 9f);
        transform.position = pos;
  
        
    }
}
