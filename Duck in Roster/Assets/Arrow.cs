using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Arrow : MonoBehaviour
{
    public GameObject arrow;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            arrow.SetActive(true);
    }
}
