using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    public Transform player;
    //############################ Procedural Programming ##############
    public Transform patrolRoute;
    public List<Transform> locations;

    private int locationIndex = 0;
    private NavMeshAgent agent;

    private int _lives = 3;
    public int EnemyLives
    {
        get { return _lives; }
        private set
        {
            _lives = value;
            if (_lives <= 0)
            {
                Destroy(this.gameObject);
                Debug.Log("Enemey Down");
            }
        }
    }

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").transform;
        InitializePatrolRoute();//this methods fill in list with child location
        MoveToNextPatrolLocation();

    }

    void MoveToNextPatrolLocation()
    {
        agent.destination = locations[locationIndex].position;
        if(locations.Count == 0)
        {
            return;// if locations is empty return is used to exit method
        }
        locationIndex = (locationIndex + 1) % locations.Count;  
    }

    void InitializePatrolRoute()
    {
        foreach(Transform child in patrolRoute)
        {
            locations.Add(child);
        }
    }

    //######################### collider Methods #####################
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            agent.destination = player.position;
            Debug.Log("Player Detected - Attack.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Player Out Of range, Resume Patrol");
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            EnemyLives -= 1;
            Debug.Log("Critical Hit!");
        }        
    }

    void Update()
    {
        if(agent.remainingDistance < 0.2f && !agent.pathPending)
        {
            MoveToNextPatrolLocation();
        }
    }
}