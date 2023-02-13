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
    public ParticleSystem dust;

    public Player playerHealth;

    private void OnEnable()
    {
        Player.OnPlayerDeath += DisablePlayerMovement;
    }

    private void OnDisable()
    {
        Player.OnPlayerDeath -= DisablePlayerMovement;
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        anim.SetBool("Jump", false);

        EnablePlayerMovement();
    }

    // Update is called once per frame
    void Update()
    {
    
        //Jumping
        grounded = Physics2D.BoxCast(transform.position, new Vector2(1.2f, 0.85f), 0, Vector2.down, 1, LayerMask.GetMask("Ground"));

       
    

    
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * MovementSpeed * Time.deltaTime;
            sr.flipX = false;
            anim.SetBool("Walk", true);
        }

       if (Input.GetKey(KeyCode.D) && grounded == false)
        {
            anim.SetBool("Walk", false);
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

       if (grounded == false)
        {
            anim.SetBool("Walk", false);
            anim.SetBool("Jump", true);
        }

        if (grounded && Input.GetKeyDown(KeyCode.Space))
        {
            CreateDust();
        }
        
    }

    private void DisablePlayerMovement()
    {
        anim.enabled = false;
        rb2.bodyType = RigidbodyType2D.Static;
    }

    private void EnablePlayerMovement()
    {
        anim.enabled = true;
        rb2.bodyType = RigidbodyType2D.Dynamic;
    }

    void CreateDust()
    {
        dust.Play();
    }


}
