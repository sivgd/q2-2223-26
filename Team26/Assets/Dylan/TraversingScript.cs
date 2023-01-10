using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraversingScript : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);

        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        anim.SetTrigger("go");


    }



}
