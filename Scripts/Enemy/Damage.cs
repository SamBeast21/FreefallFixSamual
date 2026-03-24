using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public Health pHealth;
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        GameObject temp = GameObject.FindGameObjectWithTag("Finish");
        pHealth = temp.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //sDebug.Log("Hit something!");
        if (other.gameObject.CompareTag("Finish"))
        {
            pHealth.health -= damage;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Inside something!");
        if (collision.gameObject.CompareTag("Finish"))
        {
            pHealth.health -= damage;
        }
    }
}