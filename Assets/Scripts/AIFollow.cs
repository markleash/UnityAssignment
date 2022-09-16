using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollow : MonoBehaviour
{
    [SerializeField] Transform target;
    UnityEngine.AI.NavMeshAgent navMeshAgent;

    void Start() 
    {
        navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();    
    }

    void Update() 
    {
            navMeshAgent.SetDestination(target.position);
    }
}
