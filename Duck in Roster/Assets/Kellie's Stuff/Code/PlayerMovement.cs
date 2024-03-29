using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public GameObject duck;
    public float speed = 5;
    public Rigidbody rb;
    private float horizontalInput;
    public GameObject deathScreen;
    public GameObject ui;
    public AudioSource mainTheme;
    public AudioSource gameOver;

    private void Start()
    {
        mainTheme.Play();
        mainTheme.loop = true;
        ScoreManager.score = 0;
    }


    private void FixedUpdate()
    {
        StartCoroutine(move());
        
    }
    
    IEnumerator move ()
    {
        Vector3 forwardMove = transform.forward * (speed * Time.fixedDeltaTime);
        Vector3 horizontalMove = transform.right * (horizontalInput * speed * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
        yield return new WaitForSeconds(2);
    }

    
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Vector3 pos = transform.position;
        pos.x =  Mathf.Clamp(transform.position.x, -9f, 9f);
        transform.position = pos;
  
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("drop"))
        {
            Destroy(other.gameObject);

            //old duckling spawning code; correlates to score
            /*
            switch (ScoreManager.score)
            {
                case 1 when duckie1Obtained == false:
                    duckling1 = Instantiate(duckie, transform.position, transform.rotation);
                    duckie1Obtained = true;
                    break;
                
            for (int i = 0; i < 10; i++)
            {
                Instantiate(duckie, transform.position, transform.rotation);
                FollowTarget.offset = new Vector3(0, 0, i * -20f);
            }
            
                case 2 when duckie2Obtained == false:
                    duckling2 = Instantiate(duckie2, transform.position, transform.rotation);
                    duckie2Obtained = true;
                    break;

                case 3 when duckie3Obtained == false:
                    duckling3 = Instantiate(duckie3, transform.position, transform.rotation);
                    duckie3Obtained = true;
                    break;
            }
            */
        }
        
        /*
        //old duckling deletion stuff
        if (!other.CompareTag("Obstacle")) return;
        switch (ScoreManager.score)
        {
            case 2 when duckie3Obtained:
                Destroy(duckling3);
                duckie3Obtained = false;
                break;
            case 1 when duckie2Obtained:
                Destroy(duckling2);
                duckie2Obtained = false;
                break;
            case 0 when duckie1Obtained:
                Destroy(duckling1);
                duckie1Obtained = false;
                break;
            case -1:
                Destroy(gameObject);
                mainTheme.Stop();
                mainTheme.loop = false;
                gameOver.Play();
                gameOver.loop = false;
                deathScreen.SetActive(true);
                ui.SetActive(false);
                break;
            case -2:
                Destroy(gameObject);
                mainTheme.Stop();
                mainTheme.loop = false;
                gameOver.Play();
                gameOver.loop = false;
                deathScreen.SetActive(true);
                ui.SetActive(false);
                break;
            case -3:
                Destroy(gameObject);
                mainTheme.Stop();
                mainTheme.loop = false;
                gameOver.Play();
                gameOver.loop = false;
                deathScreen.SetActive(true);
                ui.SetActive(false);
                break;
            case -4:
                Destroy(gameObject);
                mainTheme.Stop();
                mainTheme.loop = false;
                gameOver.Play();
                gameOver.loop = false;
                deathScreen.SetActive(true);
                ui.SetActive(false);
                break;
                
        }
       */

        if (ScoreManager.score <= -1)
        {
            Destroy(gameObject);
            mainTheme.Stop();
            mainTheme.loop = false;
            gameOver.Play();
            gameOver.loop = false;
            deathScreen.SetActive(true);
            ui.SetActive(false);
        }
    }
    
}

    
