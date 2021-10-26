using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotateAroundTheOwnPosition : MonoBehaviour
{
    public float duration=75f;

    void Start()
    {
        Vector3 rotateAxis = new Vector3(0, 360, 0);
        transform.DORotate(rotateAxis, duration, RotateMode.WorldAxisAdd).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        
    }
}
