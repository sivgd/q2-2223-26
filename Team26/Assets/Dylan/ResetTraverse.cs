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

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
     RenderSettings.skybox = cloudZone;
        
        if (collision.gameObject.CompareTag("Player"))
        {
            Heart.health = Heart.health - 1;
            if (Heart.health <= 0)
            {
                //AudioManager.isGameOver = true;
            }
            else
            {
                StartCoroutine(GetHurt());
            }
            collision.gameObject.GetComponent<Player>().TakeDamage(1);
        }
        rb2 = mainPlayer.GetComponent<Rigidbody2D>();
            mainPlayer.transform.localPosition = spawnpoint.transform.localPosition;
            Debug.Log("Hello");
            anim.SetBool("go", false);


    }





    IEnumerator GetHurt()
    {
        Physics2D.IgnoreLayerCollision(6, 8);
        yield return new WaitForSeconds(2);
        Physics2D.IgnoreLayerCollision(6, 8, false);
    }
}
