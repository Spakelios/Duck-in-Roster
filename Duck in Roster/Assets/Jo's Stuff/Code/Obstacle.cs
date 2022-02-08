using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damageOwie = -1;
    public AudioSource ducklingLost;

    private void OnTriggerEnter(Collider other)

    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(damageOwie);
            ducklingLost.Play();
        }
    }
}