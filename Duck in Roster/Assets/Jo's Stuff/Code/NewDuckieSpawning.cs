using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDuckieSpawning : MonoBehaviour
{
    
    public GameObject duckling;
    public int zPos;
    public Vector3 ducklingPosition;
    private Transform target;

    private GameObject newDuckling;
    private List<GameObject> ducklingConga = new List<GameObject>();

    private void LateUpdate()
    {
        ducklingPosition = new Vector3(0, 0, zPos);
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("drop"))
        {
            newDuckling = Instantiate(duckling, ducklingPosition, Quaternion.identity);
            ducklingConga.Add(newDuckling);
            zPos += -3;
        }

        else if (other.CompareTag("Obstacle"))
        {
            Destroy(ducklingConga[ducklingConga.Count - 1].gameObject);
            ducklingConga.RemoveAt(ducklingConga.Count -1);
            zPos += 3;
        }


    }
}
