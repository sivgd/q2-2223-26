using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fbmovement : MonoBehaviour
{

    private Rigidbody2D rb2;

    private float moveSpeed;
    private float jumpForce;
    
    private float moveHorizontal;
    private bool isJumping;
    private float moveVertical;


    public float speedCap = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = gameObject.GetComponent<Rigidbody2D>();

        moveSpeed = 0.1f;
        jumpForce = 60f;
        isJumping = false;



    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        if (rb2.velocity.x > speedCap)
        {
            rb2.velocity = new Vector2(speedCap, rb2.velocity.y);
        }
        if (rb2.velocity.x < -speedCap)
        {
            rb2.velocity = new Vector2(-speedCap, rb2.velocity.y);
        }


    }

    void FixedUpdate()
    {
        if(moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            rb2.AddForce(new Vector2(moveHorizontal * moveSpeed, 0f), ForceMode2D.Impulse);
        }
    }

}
