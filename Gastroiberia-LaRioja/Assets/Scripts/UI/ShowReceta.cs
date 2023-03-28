using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowReceta : MonoBehaviour
{
    public GameObject receta;
    public bool enseñar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

     private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
            //Debug.Log("Enter");
            enseñar = true;
            
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
          //  Debug.Log("Exit");
            
        }
    }
}
