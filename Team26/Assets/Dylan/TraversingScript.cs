using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TraversingScript : MonoBehaviour
{


    void Start()
    {
     
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);



    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
