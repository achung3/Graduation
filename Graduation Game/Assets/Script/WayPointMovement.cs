using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //The game will have more than one moving floor so I'm saving it as an array
    [SerializeField] GameObject[] waypoints;

    //track which waypoint I am using
    int wayPointIndex = 0;

    [SerializeField] float speed = 1f;
    // Update is called once per frame
    void Update()
    {
        //check what waypoint we need to use before moving 
        if (Vector3.Distance(transform.position, waypoints[wayPointIndex].transform.position) < .1f)
        {
            wayPointIndex++; //once we touch we change to the next waypoint

            if (wayPointIndex >= waypoints.Length)
            {
                wayPointIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[wayPointIndex].transform.position, speed * Time.deltaTime);
    }
}
