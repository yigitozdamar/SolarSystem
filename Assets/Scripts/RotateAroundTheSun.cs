using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateAroundTheSun : MonoBehaviour
{
    public Transform target;
    public PathType pathType = PathType.CatmullRom;
    public Vector3[] waypoints;
    public float duration = 50;
    void Start()
    {
      
       
        target.DOPath(waypoints, duration, pathType)
                        .SetOptions(true).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
    }

}
