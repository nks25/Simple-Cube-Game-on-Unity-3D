using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameOver gameOver;

    //When triggered, Displays the Level Complete Screen
    public void OnTriggerEnter(Collider other)
    {
        gameOver.EndLevel();
    }
}
