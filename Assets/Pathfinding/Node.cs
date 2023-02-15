using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 순수 c# 클래스 - 더이상 유니티 게임 오브젝트에 컴포넌트로 추가할 수 없음 
[System.Serializable] // 순수 c# 스크립트를 직렬화 했을 때, 인스펙터 창에서 볼 수 있게 함 
public class Node
{
    public Vector2Int coordinates;
    public bool isWalkable;
    public bool isExlored;
    public bool isPath;
    public Node connectedTo;

    public Node(Vector2Int coordinates, bool isWalkable)
    {
        this.coordinates = coordinates;
        this.isWalkable = isWalkable;
    }
}
