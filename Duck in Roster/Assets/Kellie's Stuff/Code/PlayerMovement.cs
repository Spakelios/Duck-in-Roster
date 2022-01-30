using System;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public GameObject duck;
    public float speed = 5;
    public Rigidbody rb;
    private float horizontalInput;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("drop"))
        {
            Destroy(other.gameObject);
            //Instantiate(duck, transform.position, transform.rotation);
            
        }
    }
}
