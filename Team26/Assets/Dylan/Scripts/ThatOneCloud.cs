using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThatOneCloud : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
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

        anim.SetTrigger("Go");


    }
}
