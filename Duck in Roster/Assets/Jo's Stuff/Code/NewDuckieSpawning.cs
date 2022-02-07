using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewDuckieSpawning : MonoBehaviour
{
    
    public GameObject duckling;
    public int zPos = -3;
    public bool creatingSection = false;
    private GameObject newDuckling;
    private List<GameObject> ducklingConga = new List<GameObject>();

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
          
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("drop"))
        {
            newDuckling = Instantiate(duckling, new Vector3(-2, -3, zPos), Quaternion.identity);
            ducklingConga.Add(newDuckling);
            zPos += -3;
            creatingSection = false;
        }

        else if (other.CompareTag("Obstacle"))
        {
            Destroy(ducklingConga[ducklingConga.Count - 1].gameObject);
            ducklingConga.RemoveAt(ducklingConga.Count -1);
            zPos += 3;
            creatingSection = false;
        }


    }
}
