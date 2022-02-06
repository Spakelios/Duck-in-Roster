using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DucklingDash : MonoBehaviour
{
    
public GameObject section;
    public int zPos = -3;
    public bool creatingSection = false;
    public int secNum;

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
            Instantiate(section, new Vector3(-2, -3, zPos), Quaternion.identity);
            zPos += -3;
            creatingSection = false;
            
        }
    }
}

