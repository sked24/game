using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public CharacterController2D controller;

    public float runSpeed = 40f;

    public Transform spawnpoint;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    public Vector3 respawnPoint;


    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }

    }

    void FixedUpdate()
    {

        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

    }

    //public void Respawn()
    //{
    //    this.transform.position = spawnpoint.position;
    //}




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "kill")
        {
            transform.position = respawnPoint;
        }
        if (collision.tag == "checkpoint") ;
        {
            respawnPoint = collision.transform.position;
        }
    }

}
