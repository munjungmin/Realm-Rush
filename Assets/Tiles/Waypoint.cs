using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Tower towerPrefab;
    [SerializeField] bool isPlaceable;

    // property
    // 단순히 값을 리턴하는 것으로 getter setter 메소드보다 간단, 높은 가독성
    public bool IsPlaceable { get { return isPlaceable; } }

    void OnMouseDown() 
    {
        if (isPlaceable)
        {
            bool isPlaced = towerPrefab.CreateTower(towerPrefab, transform.position);
            isPlaceable = !isPlaced;
        }
    }
    
}