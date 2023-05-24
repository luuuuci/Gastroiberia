using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class desaparecerBoton : MonoBehaviour
{
    public GameHandler gameHandler;
    public GameObject botonApagado;
    public GameObject botonContinuar;
    // Start is called before the first frame update
    void Start()
    {
        //gameHandler = FindObjectOfType(GameHandler);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameHandler.partidaGuardada == false){
            botonApagado.SetActive(true);
            botonContinuar.SetActive(false);
        }
        if(gameHandler.partidaGuardada == true){
            botonApagado.SetActive(false);
            botonContinuar.SetActive(true);

        }
    }
}
