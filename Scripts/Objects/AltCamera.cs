using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltCamera : MonoBehaviour
{
    public Transform target;      // Player
    public float smoothSpeed = 5f;
    public float yOffset = 0f;

    void LateUpdate()
    {
        transform.position = new Vector3(
            transform.position.x,
            target.position.y,
            transform.position.z
    );
    }
}