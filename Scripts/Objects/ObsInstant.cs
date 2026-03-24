using UnityEngine;
using System.Collections;

public class ObsInstant : MonoBehaviour
{
    public float interval = 3f;
    public int min = 1;
    public int max = 5;
    public GameObject[] obstacles;

    public Transform spawnPoint;

    void Start()
    {
        StartCoroutine(GenerateRandomNumber());
    }

    IEnumerator GenerateRandomNumber()
    {
        while (true)
        {
            GameObject chosenObstacle = obstacles[Random.Range(0, obstacles.Length)];

            // Optional: random Y position
            float randomY = Random.Range(min, max);

            Vector3 spawnPos = new Vector3(
                spawnPoint.position.x,
                randomY,
                spawnPoint.position.z
            );

            Instantiate(chosenObstacle, spawnPos, Quaternion.identity);

            yield return new WaitForSeconds(interval);
        }
    }
}