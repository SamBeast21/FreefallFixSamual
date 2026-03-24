using UnityEngine;
using System.Collections;

public class RandoObstacle : MonoBehaviour
{
    public float interval = 3f;
    public int min = 1;
    public int max = 5;
    public GameObject[] obstacles;

    void Start()
    {
        StartCoroutine(GenerateRandomNumber());
    }

    IEnumerator GenerateRandomNumber()
    {
        while (true)
        {
        GameObject chosenObstacle = obstacles[Random.Range(0, obstacles.Length)];

        chosenObstacle.transform.position = new Vector3(-1, 0, 0);

        yield return new WaitForSeconds(interval);
        }
    }
}