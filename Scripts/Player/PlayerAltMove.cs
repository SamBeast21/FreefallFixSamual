using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAltMove : MonoBehaviour
{
    public float speed = 5f;
    public float upwardDrift = 2f;
    public float downwardSpeed = 6f;

    private Rigidbody2D rb;
    private float horizontal;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        float verticalVelocity = upwardDrift;

        if (Input.GetKey(KeyCode.Space))
        {
            verticalVelocity = -downwardSpeed;
        }

        rb.velocity = new Vector2(horizontal * speed, verticalVelocity);
    }
}