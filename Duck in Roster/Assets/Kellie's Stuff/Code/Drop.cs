using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class Drop : MonoBehaviour
{
    public int dropValue = 1;
    public AudioSource ducklingCollected;
    
    private void OnTriggerEnter(Collider other)

    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(dropValue);
            ducklingCollected.Play();
        }
    }
}
