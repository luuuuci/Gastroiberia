using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchFish : MonoBehaviour
{
    public GameObject truchaAparecer;
    public GameObject burbujasDesaparecer;
    public GameObject objectToDestroy;
    public bool dentro;
     public Transform objectTransform;
   private void OnCollisionEnter2D(Collision2D other)
   
    {
        if (other.gameObject.CompareTag("Flecha") == true)
        {
            
           dentro = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Flecha") == true)
        {
           dentro = false;
        }
    }
    
 


public void Update (){
    //Debug.Log(dentro);
    if(dentro == true && Input.GetKeyDown(KeyCode.Space)){
        Debug.Log(dentro);
        truchaAparecer.SetActive(true);
        burbujasDesaparecer.SetActive(false);
        objectToDestroy.SetActive(false);
        //Destroy(objectToDestroy);


    }
    if(dentro == false && Input.GetKeyDown(KeyCode.Space)){
        
        SpawnRandom();


    }

    
}

public void SpawnRandom(){
        float randomX = Random.Range(-0.5f, 0.5f);
        float randomY = Random.Range(-0.5f, 0.5f);
        Vector3 newPosition = new Vector3(randomX, randomY, 0f);

        objectTransform.position = newPosition;
    }

}



