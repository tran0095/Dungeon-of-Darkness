using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deal_damage : MonoBehaviour
{
    public player_health blob;
    private void OnTriggerEnter2D(Collider2D collision)
    {



        if (collision.gameObject.CompareTag("Player"))
        {
            blob.TakeDamage(1);
        }



    }
}
