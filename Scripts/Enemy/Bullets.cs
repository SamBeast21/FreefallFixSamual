using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletMove : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }
    private void OnTriggerEnter2D(Collider2D Hit)
    {
        if(Hit.tag == "Solid")
        {
            Object.Destroy(gameObject);
        }
    }
    void Update()
    {
        float moveX = 0f;
        float moveY = 3f;

            if (Input.GetKey(KeyCode.Space))
            moveY = 4f;
            else
            moveY = 2f;


        Vector3 movement = new Vector3(moveX, moveY, 0f);
        transform.position += movement * speed * Time.deltaTime;
    }

}