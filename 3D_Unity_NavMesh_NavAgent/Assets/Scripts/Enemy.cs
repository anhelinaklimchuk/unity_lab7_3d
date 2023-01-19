using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform Player;
    public float range = 10;
    public Vector3 startpos;
    void Start()
    {
        startpos = transform.position;
        enemy = GetComponent<NavMeshAgent>();
    }


    void Update()
    { 
        if(Vector3.Distance(Player.position, transform.position) <= range)
            enemy.SetDestination(Player.position);
        else
            enemy.SetDestination(startpos);
    }
}
