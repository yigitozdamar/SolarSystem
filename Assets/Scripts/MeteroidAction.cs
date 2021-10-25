using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteroidAction : MonoBehaviour
{ 
    
    private Vector3 spawnPos;
    private float randomPosX = 4000f;
    private float randomPosZ = 1600f;
    private Vector3 targetPosition;
    [SerializeField] private float speed=0.5f;
    [SerializeField] private float distanceBetweenTargetToDeactivate = 1f;
    private void OnEnable()
    {
        targetPosition = GenerateTargetPosition();
    }
    void Update()
    {

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);

        if (Vector3.Distance(transform.position,targetPosition)< distanceBetweenTargetToDeactivate)
        {
            gameObject.SetActive(false);
        }
        
    }


    private Vector3 GenerateTargetPosition()
    {
        randomPosX = Random.Range(-randomPosX, randomPosX);
        randomPosZ = Random.Range(-randomPosZ, randomPosZ);
        spawnPos = new Vector3(randomPosX, 0, randomPosZ);
        return spawnPos;
    }
}
