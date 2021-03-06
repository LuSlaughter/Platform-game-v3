using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScript : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DoJump();
        DoMove();

    }

    void DoJump()
    {
        Vector2 velocity = rb.velocity;

        //check for jump
        if (Input.GetKey("w") && (isGrounded == true ))
        {
            if (velocity.y < 0.01f)
            {
                velocity.y = 10f;   //give the player a velocity of 5 in the y axis


            }
        }

        rb.velocity = velocity;

    }
    void DoMove()
    {
        Vector2 velocity = rb.velocity;

        //stop player sliding when not pressing left or right
        velocity.x = 0;

        //check for moving left
        if (Input.GetKey("a"))
        {
            velocity.x = -5;
        }

        //check for moving right
        if (Input.GetKey("d"))
        {
            velocity.x = 5;
        }

        if( velocity.x == 0 )
        {
            anim.SetBool("walk", false);

        }
        else
        {
            anim.SetBool("walk", true);
        }

        rb.velocity = velocity;

        // check for player moving left/right and flip the sprite

        //make player face left or right depending on whether the sprites velocity is
        if (velocity.x < -0.5f)
        {
            Helper.FlipObject(gameObject, true);
        }

        if (velocity.x > 0.5f)
        {
            Helper.FlipObject(gameObject, false);
        }



    }

    

    //check for if the sprite is grounded or is not grounded

    private void OnCollisionStay2D(Collision2D collison)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collison)
    {
        isGrounded = false;
    }
}