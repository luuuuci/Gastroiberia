using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBocadillo : MonoBehaviour
{
    public GameObject bocadillo;
  private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
           // Debug.Log("Enter");
            bocadillo.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player") == true)
        {
           // Debug.Log("Exit");
            bocadillo.SetActive(false);
        }
    }
}
