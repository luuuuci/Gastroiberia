using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class EventTrigger : MonoBehaviour
{
    public UnityEvent OnCollisionEnter;
    public UnityEvent OnCollisionExit;
    public bool playerInRange = false;
    // Start is called before the first frame update
    public void Update(){
        
    }

     

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
            
                    OnCollisionEnter.Invoke();
                    Debug.Log("Entet");
            
            
            playerInRange = true;
        
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
            Debug.Log("Exit");
            OnCollisionExit.Invoke();
            playerInRange = false;
           
        }
    }
}
