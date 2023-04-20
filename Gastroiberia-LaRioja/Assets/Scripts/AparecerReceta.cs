using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerReceta : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    public GameObject ensenarCaparrones;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.pesos >= 1){
            Debug.Log("CAPARRONE");
            ensenarCaparrones.SetActive(true);
        } else {
           ensenarCaparrones.SetActive(false);
        }
    }
}
