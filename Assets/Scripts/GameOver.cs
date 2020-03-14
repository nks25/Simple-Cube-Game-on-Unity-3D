using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{

    public float delay = 1f; // To add extra delay time after a failed attempt
    public GameObject gameObject; //To trigger the Level completion panel


    
    public void EndGame() //Game Over function call and restarts level
    {
        Debug.Log("Game Over");
        Invoke("Restart", delay);
    }
    public void EndLevel() //Level Complete function call
    {
        gameObject.SetActive(true);
    }
    void Restart() // Restart the current Scene or level
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
