using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 따라야 할 웨이포인트를 전달 

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();

    void Start()
    {
        PrintWaypointName();
    }

    void PrintWaypointName()
    {
        foreach(Waypoint waypoint in path)
        {
            Debug.Log(waypoint.name);
        }
    }
    
}