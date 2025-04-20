using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PatrollingAI : MonoBehaviour
{
    public Transform[] waypoints;
    private int currentWayPointIndex;
    private NavMeshAgent agent;




    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;


        if (waypoints.Length > 0 )
        {
            SetRandomDestination();
        }
    }


    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance < agent.stoppingDistance + 0.1f)
        {
            SetRandomDestination();
        }
    }

    int lastIndex = -1;

    void SetRandomDestination()
    {
        if (waypoints.Length == 0) return;

        int randomIndex;
        do
        {
            randomIndex = Random.Range(0, waypoints.Length);
        } while (waypoints.Length > 1 && randomIndex == lastIndex);

        lastIndex = randomIndex;
        agent.SetDestination(waypoints[randomIndex].position);
    }
}
