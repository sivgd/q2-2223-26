using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static event Action OnPlayerDeath;
    public float health, maxHealth;

    public Heart heart;

    void Start()
    {
        health = maxHealth;
    }
   
    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <= 0)
        {
            health = 0;
            Debug.Log("DEAD");
            OnPlayerDeath?.Invoke();
        }

        /*
        currentHealth -= damage;
        heart.NumberOfHearts -= damage;
        */
    
    }
    
}
