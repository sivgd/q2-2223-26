using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public static event Action OnPlayerDamaged;
    public static event Action OnPlayerDeath;

    public int maxHealth = 3;
    public int currentHealth;

    //public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        //do we wanna add a damage sound effect? add here idk
        currentHealth -= amount;
        OnPlayerDamaged?.Invoke();

        if(currentHealth <= 0)
        {
            currentHealth = 0;
            //DEAD!!!!
            //anim.SetBool("IsDead", true);
            //SceneManager.LoadScene(0);
            Debug.Log("You're Dead :(");
            OnPlayerDeath?.Invoke();

        }
    }

    /*
    public void Heal(int amount)
    {
        currentHealth += amount;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
    */
}
