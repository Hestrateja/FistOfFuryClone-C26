using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Transform[] spawnLocations;
    [SerializeField] float minTime, maxTime;
    
    // Start is called before the first frame update
    void Start()
    {

        StartSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartSpawn()
    {
        System.Random rnd = new System.Random();
        int randomSpawn = rnd.Next(0, spawnLocations.Length);
        StartCoroutine(SpawnEnemy(randomSpawn,1f));
    }
    IEnumerator SpawnEnemy(int spawner, float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        Instantiate(enemy, spawnLocations[spawner]);
        System.Random rnd = new System.Random();
        int randomSpawn = rnd.Next(0, spawnLocations.Length);
        StartCoroutine(SpawnEnemy(randomSpawn,UnityEngine.Random.Range(minTime, maxTime)));
    }
}
