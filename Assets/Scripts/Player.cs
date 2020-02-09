using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public player_health blob;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("isRunning", true);
        } else
        {
            anim.SetBool("isRunning", false);
        }

        if (blob.getHealth() <= 0)
        {
            Camera.main.transform.position = new Vector3(0, -20, -9.84f);
        }
    }
}
