using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player; //To refer to the player position
    public Text scoreText; //Used to display the Score

    //Pausing the score counter when hit with an obstacle
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.tag == "obstacle")
        {
            enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.x.ToString("0"); //Displaying the Score
    }
}
