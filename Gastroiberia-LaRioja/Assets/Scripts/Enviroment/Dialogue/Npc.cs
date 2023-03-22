using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Npc : MonoBehaviour
{
    public GameObject dialogBox;
    public GameObject botonReceta;
    public TextMeshProUGUI dialogText;
    public string dialog;
    public string dialogMission;
    public bool dialogActive;
    public bool playerInRange = false;
   
    public ItemCollectable item;
    
    void Start()
    {
        item = FindObjectOfType<ItemCollectable>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerInRange && !item.cogido)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
                

            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
                
                //Debug.Log(item.cogido);
            }
        }


        if (Input.GetKeyDown(KeyCode.E) && playerInRange && item.cogido)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
                botonReceta.SetActive(false);
                Time.timeScale = 1f;
                
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialogMission;
                //Time.timeScale = 0f;
                botonReceta.SetActive(true);
                //Debug.Log(item.cogido);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
            Debug.Log("Enter");
            playerInRange = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
            Debug.Log("Exit");
            playerInRange = false;
        }
    }
}
