using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDown : MonoBehaviour
{

    public float moveSpeed = -15f;

    public Rigidbody2D rb;

    Vector2 movement;


    // X Constant = 48.23 Beginning y =-7
    // end y is 6

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movement.y = rb.position.y + (float)moveSpeed * (float)Time.fixedDeltaTime;
        movement.x = (float)36.23;

        if (rb.position.y < -8f)
        {
            movement.y = 8f;
        }
        else if (rb.position.y > (float)10)
        {
            movement.y = (float)8;
        }
        else if (rb.position.y < -9f)
        {
            movement.y = (float)8;
        }


    }

    private void FixedUpdate()
    {
        rb.MovePosition(movement);
    }
}