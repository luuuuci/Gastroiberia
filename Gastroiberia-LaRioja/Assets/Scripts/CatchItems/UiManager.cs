using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Pausar();
    }

    public void Pausar()
    {
        Time.timeScale = 0;
    }
    public void Continuar(int numero)
    {
        Time.timeScale = numero;
    }
}
