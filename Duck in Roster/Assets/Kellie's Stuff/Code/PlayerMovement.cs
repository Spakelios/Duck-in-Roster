using System;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public GameObject duck;
    public float speed = 5;
    public Rigidbody rb;
    private float horizontalInput;
    public GameObject duckie;
    public GameObject duckie2;
    public GameObject duckie3;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * (speed * Time.fixedDeltaTime);
        Vector3 horizontalMove = transform.right * (horizontalInput * speed * Time.fixedDeltaTime);
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

            switch (ScoreManager.score)
            {
                case 1:
                    Instantiate(duckie, transform.position, transform.rotation);
                    break;
                /*
            for (int i = 0; i < 10; i++)
            {
                Instantiate(duckie, transform.position, transform.rotation);
                FollowTarget.offset = new Vector3(0, 0, i * -20f);
            }
            */
                case 2:
                    Instantiate(duckie2, transform.position, transform.rotation);
                    break;
                
                case 3:
                    Instantiate(duckie3, transform.position, transform.rotation);
                    break;
            }
        }
    }
}
