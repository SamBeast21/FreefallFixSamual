using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirlineIncrease : MonoBehaviour
{
    
    public SpriteRenderer targetRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    void Update()
    {
        targetRenderer.enabled = Input.GetKey(KeyCode.Space);
    }
}