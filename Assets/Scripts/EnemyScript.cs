using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = 0;
        float ex = transform.position.x;
        float px = player.transform.position.x;
        float dist = ex - px;

        if (dist > 0)
        {
            DoFaceLeft(true);
            velocity.x = -5;
        }

        if (dist < 0)
        {
            DoFaceLeft(false);
            velocity.x = 5;
        }
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
    
}
