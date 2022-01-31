using System;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    private Transform target;
    //public Vector3[] offset;
    public Vector3 offset = new Vector3(0f, -14f, -76f);
    //public Vector3 offset2 = new Vector3(0f, -14f, -42f);

    private void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
        
    }


    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
