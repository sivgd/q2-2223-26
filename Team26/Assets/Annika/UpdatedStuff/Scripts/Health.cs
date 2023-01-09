using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        //do we wanna add a damage sound effect? add here idk

        currentHealth -= amount;

        if(currentHealth <= 0)
        {
            //DEAD!!!!
            anim.SetBool("IsDead", true);
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
