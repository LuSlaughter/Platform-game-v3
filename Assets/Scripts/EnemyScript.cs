using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        DoJump();
        DoMove();
        DoFaceDirection();
    }

    void DoFaceDirection()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = 0;
        float ex = transform.position.x;
        float px = player.transform.position.x;
        float dist = ex - px;

        if (dist > 1)
        {
            DoFaceLeft(true);
            velocity.x = -4;
        }

        if (dist < -1)
        {
            DoFaceLeft(false);
            velocity.x = 4;
        }

        rb.velocity = velocity;
    }

    void DoFaceLeft(bool faceLeft)
    {
        if (faceLeft == true)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);

        }
    }

    void DoJump()
    {

    }

    void DoMove()
    {

    }
    
}
