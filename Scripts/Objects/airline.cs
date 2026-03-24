using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class airline : MonoBehaviour
{
    public float moveSpeed = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = 0f;
        float moveY = 5f;

            if (Input.GetKey(KeyCode.Space))
            moveY = 8f;
            else
            moveY = 4f;

        
        Vector3 movement = new Vector3(moveX, moveY, 0f);
        transform.position += movement * moveSpeed * Time.deltaTime;
        
    }
}
