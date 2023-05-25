using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpSound : MonoBehaviour
{
    public AudioSource pickUp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") == true && Input.GetKeyDown(KeyCode.Space))
        {
           
                // Play the collision sound
                pickUp.Play();
            

            
        }
    }
    
}
