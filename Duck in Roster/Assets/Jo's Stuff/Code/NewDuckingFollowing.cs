using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDuckingFollowing : MonoBehaviour
{
    private Transform target;
    private NewDuckieSpawning spawnScript;
    private Vector3 ducklingMovement;


    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        spawnScript = FindObjectOfType<NewDuckieSpawning>();
        ducklingMovement = spawnScript.ducklingPosition;
    }

    private void LateUpdate()
    {
        transform.position = target.position + ducklingMovement;
    }
}
