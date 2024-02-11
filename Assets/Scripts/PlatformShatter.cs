using UnityEngine;
using UnityEngine.SceneManagement;
public class PlatformShatter : MonoBehaviour
{
    public float platformWeight = 2f;  
    public float playerWeight = 15f;    

    void OnCollisionEnter2D(Collision2D collision)
    {

    GameObject player = GameObject.FindGameObjectWithTag("Player");
    float xScale = player.transform.localScale.x;

        if (player != null)
        {
            
            // Debug.Log("Player's X Scale: " + xScale);
        }
        else
        {
            Debug.LogWarning("Player not found in the scene.");

        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (4.5f < xScale)
            {
                Debug.Log("Player's X Scale: " + xScale);
                ShatterPlatform();
            }
        }
    }

    void ShatterPlatform()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Game Over");
    }
}