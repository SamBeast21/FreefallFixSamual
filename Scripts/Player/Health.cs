using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    AudioManager audioManager;

    public float health;
    public float maxHealth;
    public Image healthBar;


    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        maxHealth = health;
    }

    private void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        if (healthBar.fillAmount <= 0)
        {
            //audioManager.PlaySFX(audioManager.death);
            SceneManager.LoadScene("Helicopter");
        }
    }
}
