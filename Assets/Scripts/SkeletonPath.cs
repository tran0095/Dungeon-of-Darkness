using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonPath : MonoBehaviour
{

    public float moveSpeed = 1f;

    public Rigidbody2D rb;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = rb.position.x + (float)moveSpeed * (float)Time.fixedDeltaTime;
        movement.y = (float)2.74;

        if (rb.position.x < 10f)
        {
            movement.x = 22f;
        }
        else if (rb.position.x > (float)27.07)
        {
            moveSpeed = Mathf.Abs(moveSpeed) * -1f;
        }
        else if (rb.position.x < 15f)
        {
            moveSpeed = Mathf.Abs(moveSpeed);
        }


    }

    private void FixedUpdate()
    {
        rb.MovePosition(movement);
    }
}
