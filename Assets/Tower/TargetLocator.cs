using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
    Transform target;

    void Start()
    {
        // 씬 전체에 있는 첫 번째 EnemyMover를 탐색
        target = FindObjectOfType<EnemyMover>().transform;
        
    }

    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        weapon.LookAt(target);   
    }
}
