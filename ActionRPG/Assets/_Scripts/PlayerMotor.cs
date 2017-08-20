using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMotor : MonoBehaviour
{
    private NavMeshAgent _agent = null;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }
    /// <summary>
    /// Move to where we clicked
    /// </summary>
    /// <param name="point"></param>
    public void MoveToPoint(Vector3 point)
    {
        _agent.SetDestination(point);
    }

}
