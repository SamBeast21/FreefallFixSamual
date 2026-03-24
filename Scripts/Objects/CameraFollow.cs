using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5f;
    public float yOffset = 0f;
    public float minX, maxX;
    public float minY, maxY;
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = new Vector3(
            transform.position.x,
            target.position.y + yOffset,
            transform.position.z
        );

        float camHeight = cam.orthographicSize;
        float camWidth = camHeight * cam.aspect;

        float clampedX = Mathf.Clamp(
            desiredPosition.x,
            minX + camWidth,
            maxX - camWidth
        );

        float clampedY = Mathf.Clamp(
            desiredPosition.y,
            minY + camHeight,
            maxY - camHeight
        );

        Vector3 clampedPosition = new Vector3(
            clampedX,
            clampedY,
            desiredPosition.z
        );

        transform.position = Vector3.Lerp(
            transform.position,
            clampedPosition,
            smoothSpeed * Time.deltaTime
        );
    }
}