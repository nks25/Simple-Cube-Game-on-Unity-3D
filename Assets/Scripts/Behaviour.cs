using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour : MonoBehaviour
{
    public Rigidbody rb; //Refering to the player object
    public float sideForce; //Managing the force to move the player sideways
    public float forwardForce; //Force used to go forward
    public GameOver gameover; //Game Ending conditions parameter

    void Update()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0); //So the player keeps moving forward
        
       

        if (Input.GetKey("d")) // To move player right
        {
            rb.AddForce(0, 0, -sideForce*Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))// To move player left
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        //Jumping After reaching a checkpoint
        if(transform.position.x > 90 && transform.position.y <=0.5 && transform.position.z >-3.5 && transform.position.z < 5.5) 
        {
            if (Input.GetKeyDown("w"))
            {
                rb.AddForce(0, 300, 0);
            }
        }
        //Falling off the grid condition and then resetting the level
        if(transform.position.y <= -1)
        {
            //FindObjectOfType<GameOver>().EndGame();
            gameover.EndGame();
        }

    }
}
