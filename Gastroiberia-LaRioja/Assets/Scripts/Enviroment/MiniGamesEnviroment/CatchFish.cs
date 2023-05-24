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
     public ShowBocadillo showbocadillo;
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
     startAnimation();
    //Debug.Log(dentro);
    if(dentro == true && Input.GetKeyDown(KeyCode.Space) && showbocadillo.ensena == true){
        //stopAnimation();
        Debug.Log(dentro);
        truchaAparecer.SetActive(true);
        burbujasDesaparecer.SetActive(false);
        objectToDestroy.SetActive(false);
        //Destroy(objectToDestroy);


    }
    if(dentro == false && Input.GetKeyDown(KeyCode.Space) && showbocadillo.ensena == true){
        stopAnimation();
        SpawnRandom();
        startAnimation();

    }

    
}
public void startAnimation(){
    GameObject otherObject = GameObject.Find("Bubbles1");
        Animator otherAnimator = otherObject.GetComponent<Animator>();
        otherAnimator.enabled = true;
}
public void stopAnimation(){
    GameObject otherObject = GameObject.Find("Bubbles1");
        Animator otherAnimator = otherObject.GetComponent<Animator>();
        otherAnimator.enabled = false;
}

public void SpawnRandom(){
        float randomX = Random.Range(-0.6f, 5.5f);
        float randomY = Random.Range(-9.1f, -10.5f);
        Vector3 newPosition = new Vector3(randomX, randomY, 0f);

        objectTransform.position = newPosition;
    }

}



