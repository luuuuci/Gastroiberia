using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missed : MonoBehaviour
{
    public int fallos;
    public GameObject menuPerder;
    public GameObject x1;
    public GameObject x2;
    public GameObject x3;
public AudioSource soundClip;
public AudioSource pararMusica;


    private void Update()
    {
        if(fallos == 1){
            x1.SetActive(true);
        }
        if(fallos == 2){
            x2.SetActive(true);
        }
        if(fallos == 3)
        {
            Time.timeScale = 0f;
            x3.SetActive(true);
            menuPerder.SetActive(true);
            Debug.Log("LOSE");
            pararMusica.Pause();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            soundClip.Play();
            fallos++;
            Debug.Log(fallos);
        }
    }


}
