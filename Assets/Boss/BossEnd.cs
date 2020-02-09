using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnd : MonoBehaviour
{

    public GameObject Entrance;

    public float moveSpeed = 0f;

    public Rigidbody2D rb;

    Vector2 movement;


    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject player = collision.gameObject;
            movement.x = rb.position.x + (float)moveSpeed * (float)Time.fixedDeltaTime;
            movement.y = 20;

            moveSpeed = 20f;

        }
        



    }

   
}
