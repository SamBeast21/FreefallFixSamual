using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parachute : MonoBehaviour
{
    public Vector3 normalScale = new Vector3(0.6f, 0f, 1f);
    public Vector3 ParaScale = new Vector3(2.6f, 4.8f, 1f);
    public Vector3 DiveScale = new Vector3(0f, 0f, 1f);
    public float scaleSpeed = 8f;
    public bool ParaOn;
    public bool isDiving;

    void Update()
    {
    ParaOn = Input.GetKey(KeyCode.UpArrow);
    isDiving = Input.GetKey(KeyCode.Space);

    Vector3 targetScale;

    if (ParaOn && !isDiving)
    {
        targetScale = ParaScale;
    }
    else if (isDiving)
    {
        targetScale = DiveScale;
    }
    else
    {
        targetScale = normalScale;
    }

    transform.localScale = Vector3.Lerp(
        transform.localScale,
        targetScale,
        scaleSpeed * Time.deltaTime
    );
    }
}