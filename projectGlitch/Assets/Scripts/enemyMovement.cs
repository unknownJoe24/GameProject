using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyMovement : MonoBehaviour
{

    public Transform player; //get player object to track
    NavMeshAgent nav;

    // Start is called before the first frame update
    void Start()
    {
        //get player object from tag
        player = GameObject.FindGameObjectWithTag("Player").transform;
        //get navmesh
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }
}
