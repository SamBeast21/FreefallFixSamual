using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCloudReset : MonoBehaviour

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
        respawnOffset = Random.Range(12f, 16f);
        Vector3 pos = transform.position;
        pos.y -= respawnOffset;
        float randomX = Random.Range(-5f, 5f);
        float scale = Random.Range(0.8f, 1.6f);
        transform.position = new Vector3(randomX, pos.y - respawnOffset, pos.z);
        transform.localScale = new Vector3(scale, scale, 1f);    
    }
}