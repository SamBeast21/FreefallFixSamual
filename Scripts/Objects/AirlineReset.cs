using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirlineReset : MonoBehaviour
{
    public float respawnOffset;

    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.CompareTag("CloudReset"))
        
        {
            Respawn();
        }
    }

    void Respawn()
    {
        respawnOffset = Random.Range(7f, 10f);
        Vector3 pos = transform.position;
        pos.y -= respawnOffset;
        float randomX = Random.Range(-3f, 3f);
        float scale = Random.Range(0.8f, 1.6f);
        transform.position = new Vector3(randomX, pos.y - respawnOffset, pos.z);
        transform.localScale = new Vector3(scale, scale, 1f);    
    }
}