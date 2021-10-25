using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteroidAction : MonoBehaviour
{ 
    
    private Vector3 spawnPos;
    private float randomPosX = 4000f;
    private float randomPosZ = 1600f;

     void Start()
    {

        transform.position = Vector3.Lerp(transform.position, GenerateSpawnPosition(), Time.deltaTime * 10);
        
    }


    private Vector3 GenerateSpawnPosition()
    {
        randomPosX = Random.Range(-randomPosX, randomPosX);
        randomPosZ = Random.Range(-randomPosZ, randomPosZ);
        spawnPos = new Vector3(randomPosX, 0, randomPosZ);
        return spawnPos;
    }
}
