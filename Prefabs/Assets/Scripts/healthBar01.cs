using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//############### HEALTH BAR #################


public class healthBar01 : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    private float MaxHealth = 100;
    public PlayerController Player;

    private void Start()
    {
        HealthBar = GetComponent<Image>();
        Player = FindObjectOfType<PlayerController>();
    }
    private void Update()
    {
        CurrentHealth = Player.Health;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}
