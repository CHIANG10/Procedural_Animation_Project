﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class new_bone_controller : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent myAgent;

    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        myAgent.SetDestination(target.position);
    }
}
