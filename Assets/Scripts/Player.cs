using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent myAgent;
    private bool isMoving = false;
    public Transform goal;


    void Start() {
        myAgent = GetComponent<NavMeshAgent>();
    }

    public void MoveStart()
    {
        if (!isMoving)
        {
            myAgent.destination = goal.position;
            isMoving = true;
        }
    }
}
