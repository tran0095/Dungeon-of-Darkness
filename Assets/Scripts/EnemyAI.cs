using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyAI : MonoBehaviour
{
    public Transform target;

    public float speed = 350f;
    public float nextWaypointDisntace = 3f;

    Path path;

    Seeker seeker;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        

        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();

        seeker.StartPath(rb.position, target.position, OnPathComplete);
    }

    void OnPathComplete(Path p)
    {
        if (!p.error)
        {
            path = p;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
