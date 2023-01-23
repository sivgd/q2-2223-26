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
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        anim.SetBool("Jump", false);
    }

    // Update is called once per frame
    void Update()
    {
    
        //Jumping
        grounded = Physics2D.BoxCast(transform.position, new Vector2(0.1f, 1.4f), 0, Vector2.down, 1, LayerMask.GetMask("Ground"));

       
    

    
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * MovementSpeed * Time.deltaTime;
            sr.flipX = false;
            anim.SetBool("Walk", true);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            anim.SetBool("Walk", false);
        }




        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * MovementSpeed * Time.deltaTime;
            sr.flipX = true;
            anim.SetBool("Walk", true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            anim.SetBool("Walk", false);
        }

        if (grounded == true)
        {   
            anim.SetBool("Jump", false);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb2.velocity = new Vector2(rb2.velocity.x, JumpHeight);
                anim.SetBool("Jump", true);
            }

         
        }

        //this.transform.localScale = new Vector3(100 , 10, 10);
        //Debug.Log(this.transform.lossyScale);

    }




}
