using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public ObjectPooler meteorPrefab;       // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.

    private Vector3 spawnPos;
    private float randomPosX = 4000f;
    private float randomPosZ = 1600f;


    void Start()
    {
        
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating(nameof(SpawnMeteroidFromPool), spawnTime, spawnTime);
    }


    void SpawnMeteroidFromPool()
    {
        var meteorPrefab = ObjectPooler.SharedInstance.GetPooledObject();
        meteorPrefab.transform.position = GenerateSpawnPosition();


        Instantiate(meteorPrefab, transform.position, transform.rotation);
    }
    private Vector3 GenerateSpawnPosition()
    {
        randomPosX = Random.Range(-randomPosX, randomPosX);
        randomPosZ = Random.Range(-randomPosZ, randomPosZ);
        spawnPos = new Vector3(randomPosX, 0, randomPosZ);
        return spawnPos;
    }
}
