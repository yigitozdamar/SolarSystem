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

        Tween t = target.DOPath(waypoints, duration, pathType)
                        .SetOptions(true).SetLoops(-1);
        t.SetEase(Ease.Linear).SetLoops(-1, LoopType.Restart);
    }

}
