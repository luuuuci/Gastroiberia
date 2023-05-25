using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerAgua : MonoBehaviour
{
    public GameObject aguaPlayer;
    public AudioSource agua;
    public Player player;
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
            player.isWater = true;
            Debug.Log("Enter");
            aguaPlayer.SetActive(true);
            if(!agua.isPlaying){
                agua.Play();
            }

            
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
            player.isWater = false;
            Debug.Log("Exit");
            aguaPlayer.SetActive(false);
            if(!agua.isPlaying){
                agua.Play();
            }
            
        }
    }
}
