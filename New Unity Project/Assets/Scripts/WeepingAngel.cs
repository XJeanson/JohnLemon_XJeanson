using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeepingAngel : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent navMeshAgent;
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent.SetDestination(player.position);
    }

    // Update is called once per frame
    void Update()
    {
        //if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        //{
            navMeshAgent.SetDestination(player.position);
        //}
    }
}
