using UnityEngine;
using System.Collections;

public class ObsGenerator : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float spawnInterval = 2f;

    public Vector2 minSpawnPos;
    public Vector2 maxSpawnPos;

    void Start()
    {
        StartCoroutine(SpawnObstacle());
    }

    IEnumerator SpawnObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            int randomIndex = Random.Range(0, obstaclePrefabs.Length);
            GameObject prefabToSpawn = obstaclePrefabs[randomIndex];

            float x = Random.Range(minSpawnPos.x, maxSpawnPos.x);
            float y = Random.Range(minSpawnPos.y, maxSpawnPos.y);

            Vector2 spawnPos = new Vector2(x, y);

            Instantiate(prefabToSpawn, spawnPos, Quaternion.identity);
        }
    }
}