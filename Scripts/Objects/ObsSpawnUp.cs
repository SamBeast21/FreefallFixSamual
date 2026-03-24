using UnityEngine;
using System.Collections;

public class ObsSpawnUp : MonoBehaviour
{
    public float interval = 3f;
    public float minInterval = 0.8f;
    public float decreaseRate = 0.1f;

    public int min = 1;
    public int max = 5;
    public GameObject[] obstacles;

    public Transform[] spawnPoints; // multiple spawn points

    void Start()
    {
        StartCoroutine(GenerateRandomNumber());
    }

    IEnumerator GenerateRandomNumber()
    {
        while (true)
        {
            GameObject chosenObstacle = obstacles[Random.Range(0, obstacles.Length)];

            Transform chosenSpawn = spawnPoints[Random.Range(0, spawnPoints.Length)];

            //float randomY = Random.Range(min, max);

            Vector3 spawnPos = new Vector3(
                chosenSpawn.position.x,
                //randomY, 
                chosenSpawn.position.y,
                chosenSpawn.position.z
            );

            Instantiate(chosenObstacle, spawnPos, Quaternion.identity);

            yield return new WaitForSeconds(interval);

            if (interval > minInterval)
            {
                interval -= decreaseRate;
            }
        }
    }
}