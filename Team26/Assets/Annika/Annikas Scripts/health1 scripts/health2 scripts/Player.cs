using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;

    public Heart heart;
    //public EnemyDamage damg;

    void Start()
    {
        currentHealth = maxHealth;
    }

    //Update is called once per frame
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.H))
        {
            TakeDamage(1);
        }
    
    }
    

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        heart.NumberOfHearts -= damage;
    }
}
