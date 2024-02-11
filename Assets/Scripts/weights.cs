using UnityEngine;
using UnityEngine.SceneManagement;

public class weights : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {

    // GameObject player = GameObject.FindGameObjectWithTag("Player");
    // float xScale = player.transform.localScale.x;

    // GameObject ball = GameObject.FindGameObjectWithTag("Spiked Ball");
    // float xScales = ball.transform.localScale.x;
// Debug.Log("Player's X Scale: " + xScale);
        if (collision.gameObject.CompareTag("Player"))
        {
// Debug.Log("Player's X Scale: " + xScale);
// Debug.Log("Ball's X Scale: " + xScales);

            // Compare weights and shatter the platform if the platform's weight is greater
            float xScale = collision.gameObject.transform.localScale.x;
            float xScales = gameObject.transform.localScale.x;
            if (xScales > xScale)
            {
                Debug.Log("Player's X Scale: " + xScale);
                ShatterPlatform();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    void ShatterPlatform()
    {
        // Implement your platform shattering logic here
        // For demonstration purposes, let's destroy the platform
        // GameObject player = GameObject.FindGameObjectWithTag("Player");
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Destroy(player);
        SceneManager.LoadScene("Game Over");
    }
}