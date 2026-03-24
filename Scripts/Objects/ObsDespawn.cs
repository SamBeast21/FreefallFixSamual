using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsDespawn : MonoBehaviour
{
    
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.CompareTag("CloudReset"))
        
        {
            Debug.Log("yes");
            Object.Destroy(gameObject);
        }
    }
}