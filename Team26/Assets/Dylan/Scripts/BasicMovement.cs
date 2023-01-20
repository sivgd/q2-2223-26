using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    bool grounded = false;
    public ParticleSystem dust;
    private float moveSpeed;
    private float moveHorizontal;

    //references
    
    private Rigidbody2D rb2;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();

        //moveSpeed = 7f;

        
    }

    // Update is called once per frame
    void Update()
    {

        //Horizontal Movement
        float horizvalue = Input.GetAxis("Horizontal");

        rb2.velocity = new Vector2(horizvalue * 7, rb2.velocity.y);
        CreateDust();




        //Jumping
        grounded = Physics2D.BoxCast(transform.position, new Vector2(0.1f, 0.1f), 0, Vector2.down, 1, LayerMask.GetMask("Ground"));

        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb2.velocity = new Vector2(rb2.velocity.x,8);
            CreateDust();
        }

    }
    void CreateDust()
    {
        dust.Play();
    }

}
