using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject asteroidPrefab;
    public float spawnRate = 30f;
    public float spawnRateIncrement = 1f;

    private float nextSpawnTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > nextSpawnTime){
            nextSpawnTime = Time.time + 60 / spawnRate;
            spawnRate += spawnRateIncrement;

            Vector3 spawnPoint = new Vector3(Random.Range(-12, 3), 8, 8.87f);
            GameObject meteor = Instantiate(asteroidPrefab, spawnPoint, Quaternion.identity);
            Destroy(meteor, 3f);
        }
    }
}
