using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Dive player;

    public float score;
    public float pointsPerSecond = 10f;
    public float diveMultiplier = 2f;

void Update()
    {   
    float multiplier = 1f;

    if (player.isDiving)
    {
        multiplier *= diveMultiplier;
    }

    multiplier *= player.GetHighestZoneMultiplier();

    score += pointsPerSecond * multiplier * Time.deltaTime;
    scoreText.text = "Score: " + Mathf.FloorToInt(score);
    }
}