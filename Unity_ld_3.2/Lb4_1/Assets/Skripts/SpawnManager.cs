using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;
    public int enemyCount;
    public int waveNumder=1;
    public GameObject powerupPrefab;
    // Start is called before the first frame update

    void Start()
    { 
        SpawnEnemywave(waveNumder);
        Instantiate(powerupPrefab, GenerateSpawnPosition(),powerupPrefab.transform.rotation);
      
    }
   void SpawnEnemywave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++) { Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation); }
    }
    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<enemy>().Length;
        if (enemyCount == 0) 
        { 
            waveNumder++; 
            SpawnEnemywave(waveNumder);
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}
