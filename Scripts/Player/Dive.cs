using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dive : MonoBehaviour
{
    AudioManager audioManager;

    public Vector3 normalScale = new Vector3(1f, 1f, 1f);
    public Vector3 diveScale = new Vector3(0.7f, 1.3f, 1f);
    public float scaleSpeed = 8f;
    public bool isDiving;
    private List<ScoreZone> activeZones = new List<ScoreZone>();
    public float GetHighestZoneMultiplier()
        {
        float highest = 1f;

        foreach (ScoreZone zone in activeZones)
        {
            if (zone.multiplier > highest)
            {
                highest = zone.multiplier;
            }
        }
            return highest;
        }

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Update()
    {
        {
            isDiving = Input.GetKey(KeyCode.Space);
        }
        Vector3 targetScale = isDiving ? diveScale : normalScale;

        transform.localScale = Vector3.Lerp(
            transform.localScale,
            targetScale,
            scaleSpeed * Time.deltaTime
        );

        //audioManager.PlaySFX(audioManager.windNormal);

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        ScoreZone zone = other.GetComponent<ScoreZone>();
        if (zone != null)
        {
            activeZones.Add(zone);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        ScoreZone zone = other.GetComponent<ScoreZone>();
        if (zone != null)
        {
            activeZones.Remove(zone);
        }
    }
}