using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentBehaviour : MonoBehaviour
{
    //where do you want the agent to go to?
    public Transform target;
    //which agent should be moving there?
    private NavMeshAgent agent;


    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
    }

    
    void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }



    }
}
