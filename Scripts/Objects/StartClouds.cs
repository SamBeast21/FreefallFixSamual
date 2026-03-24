using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartClouds : MonoBehaviour
{
    public float moveSpeed = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0.2f;
        float moveY = 0f;
        Vector3 movement = new Vector3(moveX, moveY, 0f);
        transform.position -= movement * moveSpeed * Time.deltaTime;
        
    }
}
