using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 따라야 할 웨이포인트를 전달 

public class EnemyMover : MonoBehaviour
{
    [SerializeField] List<Waypoint> path = new List<Waypoint>();
    [SerializeField] [Range(0f, 5f)] float speed = 1f;

    void Start()
    {
        StartCoroutine(FollowPath());
    }

    // 코루틴
    IEnumerator FollowPath()
    {
        foreach(Waypoint waypoint in path)
        {
            // Lerp : Linear Interpolation 시작과 종료 지점 간 움직임을 부드럽게 만들기
            Vector3 startPosition = transform.position;
            Vector3 endPosition = waypoint.transform.position;
            float travelPercent = 0f;

            // 적이 가는 경로를 바라보도록 함
            transform.LookAt(endPosition);  

            while(travelPercent < 1f)
            {
                travelPercent += Time.deltaTime * speed;
                transform.position = Vector3.Lerp(startPosition, endPosition, travelPercent);
                yield return new WaitForEndOfFrame();  // 프레임 끝까지 기다린 후 다시 코루틴 시작
            }

        }
    }
    
}