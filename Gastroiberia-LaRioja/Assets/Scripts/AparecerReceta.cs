using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AparecerReceta : MonoBehaviour
{
    public GameHandler gameHandler;
    public GameObject ensenarCaparrones;
    public GameObject ensenarTrucha;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameHandler.recetasAmounta >= 1){
            //Debug.Log("CAPARRONE");
            ensenarCaparrones.SetActive(true);
        } else {
           ensenarCaparrones.SetActive(false);
           ensenarTrucha.SetActive(false);
        }
        if(gameHandler.recetasAmounta >= 2){
            ensenarTrucha.SetActive(true);
        } else { 
           ensenarTrucha.SetActive(false);
        }
        
    }
}
