using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewController : MonoBehaviour
{
    public float MovementSpeed;
    public float JumpHeight;
   
    public bool grounded = false;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;


    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    
        //Jumping
        grounded = Physics2D.BoxCast(transform.position, new Vector2(0.1f, 1.31f), 0, Vector2.down, 1, LayerMask.GetMask("Ground"));

       
    

    
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * MovementSpeed * Time.deltaTime;
            sr.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * MovementSpeed * Time.deltaTime;
            sr.flipX = true;
        }

        if (grounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2.velocity = new Vector2(rb2.velocity.x, JumpHeight);
            }

        }

    }




}
