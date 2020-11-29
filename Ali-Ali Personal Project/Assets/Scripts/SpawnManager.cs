using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] traffic;
    public GameObject coins;

    private float zTrafficSpawn = 19f;
    private float xSpawnRange = 13f;
    private float zcoinSpawnRange = 12f;
    private float ySpawn = 0.53f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("trafficSpawn", 1.0f, 1.0f);
        InvokeRepeating("coinSpawn", 1.0f, 6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void trafficSpawn()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, traffic.Length);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zTrafficSpawn);

        Instantiate(traffic[randomIndex], spawnPos, traffic[randomIndex].gameObject.transform.rotation);
    }

    void coinSpawn()
    {
        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(4, zcoinSpawnRange);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, randomZ);

        Instantiate(coins, spawnPos, coins.gameObject.transform.rotation);
    }
}
