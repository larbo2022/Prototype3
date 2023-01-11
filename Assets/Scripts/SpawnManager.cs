using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private PlayerController playerController;
    Vector3 spawnPos = new Vector3(25, 0, 0);

    private float startDelay = 2f;
    private float spawnInterval = 2f;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
    }


    void SpawnRandomObstacle()
    {
        if (playerController.gameOver == false)
        {
          int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
       
          Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
        }
       
    }
}
