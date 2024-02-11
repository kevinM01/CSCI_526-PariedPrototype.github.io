using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeIncrease : MonoBehaviour
{
    // Start is called before the first frame update
    private float sizeIncreaseAmount = 0.81f;
    private float rotateChange = 100;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, -(rotateChange * Time.deltaTime));   
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.localScale += new Vector3(sizeIncreaseAmount, sizeIncreaseAmount, sizeIncreaseAmount);
            Destroy(gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        }
    }

}
