using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerParaMove : MonoBehaviour
{
    public float speed = 5f;
    public float upwardDrift = 2f;
    public float ParaDrift = 3.5f;
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

    bool isDiving = Input.GetKey(KeyCode.Space);
    bool parachuteOn = Input.GetKey(KeyCode.UpArrow);

    if (isDiving)
    {
        verticalVelocity = -downwardSpeed;
    }
    else if (parachuteOn)
    {
        verticalVelocity = ParaDrift;
    }

    rb.velocity = new Vector2(horizontal * speed, verticalVelocity);
    }
}