using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 따라야 할 웨이포인트를 전달 

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] float waitTime = 1f;
    void Start()
    {
        StartCoroutine(FollowPath());
    }

    // 코루틴
    IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path)
        {
            transform.position = waypoint.transform.position;
            yield return new WaitForSeconds(waitTime);
        }
    }
    
}