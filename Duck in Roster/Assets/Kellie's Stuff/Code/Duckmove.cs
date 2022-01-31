using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duckmove : MonoBehaviour
{
    public Transform objectToFollow;
    public Vector3 offset;
    public float speed = 5;
    public Rigidbody rb;
    private float horizontalInput;

    
    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }
   
    void Update()
    {
        transform.position = objectToFollow.position + offset;

        horizontalInput = Input.GetAxis("Horizontal");
    }
}