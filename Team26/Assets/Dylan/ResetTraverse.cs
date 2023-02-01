using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTraverse : MonoBehaviour
{
    public GameObject spawnpoint;
    public GameObject mainPlayer;
    private Rigidbody2D rb2;
    public Animator anim;

    void Start()
    {
        //Get the Animator attached to the GameObject you are intending to animate.
        anim = gameObject.GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //anim.SetBool("go", false);
        //Debug.Log("Hello");

    }


    private void OnCollisionStay2D(Collision2D collision)
    {

        anim.SetBool("go", false);
        Debug.Log("Hello");




        if (collision.gameObject.CompareTag("Player"))
        {
            Heart.health--;
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

       

        IEnumerator GetHurt()
        {
            Physics2D.IgnoreLayerCollision(6, 8);
            yield return new WaitForSeconds(2);
            Physics2D.IgnoreLayerCollision(6, 8, false);
        }




    }
    private void OnTriggerEnter2D(Collider2D collision)
    {





        if (collision.tag == "Player")
        {
            rb2 = mainPlayer.GetComponent<Rigidbody2D>();
            mainPlayer.transform.localPosition = spawnpoint.transform.localPosition;
        }
    }
}
