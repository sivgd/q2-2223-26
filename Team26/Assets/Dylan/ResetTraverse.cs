using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTraverse : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject mainPlayer;
    private Rigidbody2D rb2;
    public Animator anim;
    public Material cloudZone;

    void Start()
    {
        
        anim = gameObject.GetComponent<Animator>();
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    

    //}


   


    
    private void OnTriggerEnter2D(Collider2D collision)
    {

      
        



        if (collision.tag == "Player")
        {
            rb2 = mainPlayer.GetComponent<Rigidbody2D>();
            mainPlayer.transform.localPosition = spawnpoint.transform.localPosition;
            Debug.Log("Hello");
            anim.SetBool("go", false);
            RenderSettings.skybox = cloudZone;
        }
        
    }
}
