using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Duckling_AI : MonoBehaviour
{
    public NavMeshAgent duckling;
    public Transform player;

    void Update()
    {
        duckling.SetDestination(player.position);
    }

}
