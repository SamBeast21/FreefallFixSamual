using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public bool isDiving;

    void Update()
    {
        float moveX = 0f;
        float moveY = 0.5f;


        if (Input.GetKey(KeyCode.LeftArrow))
            if (Input.GetKey(KeyCode.Space))
            moveX = -0.7f;
            else
            moveX = -1.5f;


        if (Input.GetKey(KeyCode.RightArrow))
            if (Input.GetKey(KeyCode.Space))
            moveX = 0.7f;
            else
            moveX = 1.5f;

        if (Input.GetKey(KeyCode.Space))
            moveY = -1.5f;



        //if (Input.GetKey(KeyCode.UpArrow))
            //moveY = 1f;
            //if (Input.GetKey(KeyCode.Space))
            //moveY = 0.7f;

        Vector3 movement = new Vector3(moveX, moveY, 0f);
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D Hit)
    {
        //if(Hit.tag == "Bullet")
        {
            //Object.Destroy(gameObject);
        }
    }
}