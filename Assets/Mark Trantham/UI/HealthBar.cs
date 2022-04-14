using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{


    [Header("Health Bar Fill")]
    public Slider myHealthSlider;
    [Header("Health Bar Text Value")]
    public TextMeshProUGUI myHealthValue;
    
    
    
    //testing Player's health
    [Header("Player Health Testing")]
    public int maxHealth = 100;
    public int currentHealth;


    private void Start()
    {
        //Testing Player's health;
        currentHealth = maxHealth;
        
        //Set slider to player's max health at start of game.
        SetMaxHealth(maxHealth);
        
        //Have HealthTextValue set to players current health(maxHealth) at start of game.
        myHealthValue.text = $"{currentHealth}";
        
        
        
    }

    private void Update()
    {
        //Updating Health text value 
        //If health is above 0 display the value, else display "Slayed"
        if (currentHealth > 0)
        {
            myHealthValue.text = $"{currentHealth}";
        }
        else
        {
            myHealthValue.text = "Slayed";
        }


        //testing player takes damage or enemy, to then update health bar with correct value.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }


    //Set slider's maxValue
    public void SetMaxHealth(int health)
    {
        //myHealthSlider.maxValue = GameManager.Instance.playerStats.MaxHealth;
        myHealthSlider.maxValue = health;
        myHealthSlider.value = health;
    }

    //Set slider's current value
    public void SetHealth(int health)
    {
        myHealthSlider.value = health;
    }


    //Testing player taking damage, update to UI
    private void TakeDamage(int damage)
    {
        currentHealth -= damage;
        SetHealth(currentHealth);
    }
}
