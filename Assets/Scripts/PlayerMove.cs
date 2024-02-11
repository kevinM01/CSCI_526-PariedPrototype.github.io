using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D player;
    private float speed = 10;
    void Start()
    {
         player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        player.velocity = new Vector2(horizontalInput * speed, player.velocity.y);
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            player.velocity = new Vector2(player.velocity.x, speed);
        }
        
    }

     void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Fall")
        {
            SceneManager.LoadScene("Game Over");
        }
    }
    
}
