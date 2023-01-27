using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bobbing : MonoBehaviour
{
    
    public float amp;
    
    public float freq;
    Vector3 initPos;

    private void Start()
    {
        initPos = transform.position;
    }

    // moves through x-axis and changes y-axis position. sideways S.
    private void Update()
    {

        transform.position = new Vector3(initPos.x, Mathf.Sin(Time.time * freq) * amp + initPos.y, 0);
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
