using System;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    private Transform target;
    public Vector3 offset = new Vector3(0f, 7.5f, 0f);

    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }


    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
