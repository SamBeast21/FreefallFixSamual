using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour

{
    public float parallaxMultiplier = 0.5f;

    private Transform cam;
    private Vector3 lastCamPosition;

    void Start()
    {
        cam = Camera.main.transform;
        lastCamPosition = cam.position;
    }

    void LateUpdate()
    {
        Vector3 delta = cam.position - lastCamPosition;
        transform.position += new Vector3(0, delta.y * parallaxMultiplier, 0);
        lastCamPosition = cam.position;
    }
}