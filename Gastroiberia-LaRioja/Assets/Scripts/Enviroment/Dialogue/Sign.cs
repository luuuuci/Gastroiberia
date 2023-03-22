using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sign : MonoBehaviour
{
    public GameObject dialogBox;
    public TextMeshProUGUI dialogText;
    public string dialog;
    public bool dialogActive;
    public bool playerInRange = false;

  void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && playerInRange)
        {
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
                Time.timeScale = 1f;
            }
            else
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
                Time.timeScale = 0f;
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
