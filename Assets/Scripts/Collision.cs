using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Behaviour behaviour; //refering the player functions
    public GameOver gameover; //refering the game ending functions
    

    //Checking for Collisions
    void OnCollisionEnter(UnityEngine.Collision collision)
    {
        //Resetting the game when colliding with an obstacle
        if(collision.collider.tag == "obstacle")
        {
            behaviour.enabled = false;
            //FindObjectOfType<GameOver>().EndGame();
            gameover.EndGame();
        }

    }
    
}
