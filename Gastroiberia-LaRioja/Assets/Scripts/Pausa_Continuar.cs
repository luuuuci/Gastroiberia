using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa_Continuar : MonoBehaviour
{

     public void Pausar(){
        Time.timeScale = 0f;
    }
    public void Continuar(){
        Time.timeScale = 1f;
    }
}
