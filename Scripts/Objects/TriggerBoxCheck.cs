using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerBoxCheck : MonoBehaviour
{
    [Header("Main")]
    public bool inTrigger;
    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        if (inTrigger == true)
            if (Input.GetKeyDown(KeyCode.S))
            {
                SceneManager.LoadScene("SampleScene");
                    Player.SetActive(true);
            }
        if (inTrigger == true)
            if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SceneManager.LoadScene("SampleScene");
            Player.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inTrigger = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inTrigger = true;
        }
    }
}