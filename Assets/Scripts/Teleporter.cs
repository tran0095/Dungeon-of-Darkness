using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{

    public GameObject Entrance;

    public GameObject Exit;
    public GameObject cameraPosition;

    public Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        


        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject player = collision.gameObject;
            player.transform.position = Exit.transform.position;
            Camera.main.transform.position = cameraPosition.transform.position;


        }


        
    }

}
