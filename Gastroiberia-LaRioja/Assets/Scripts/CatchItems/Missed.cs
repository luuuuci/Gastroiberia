using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missed : MonoBehaviour
{
    public int fallos;
    public GameObject menuPerder;


    private void Update()
    {
        if(fallos == 3)
        {
            Time.timeScale = 0f;
            menuPerder.SetActive(true);
            Debug.Log("LOSE");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            
            fallos++;
            Debug.Log(fallos);
        }
    }


}
