using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showCaparrones : MonoBehaviour
{
     [SerializeField] GameManager gameManager;
    public GameObject caparrones;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.pesos >= 1){

            Debug.Log("DESCBLOQUEADO");
        }
    }
}
