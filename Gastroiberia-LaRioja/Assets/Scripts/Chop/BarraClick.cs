using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BarraClick : MonoBehaviour
{
    public Image barra;
    public float barraActual;
    public float barraMax;

    [SerializeField] GameObject menuPausa;
    [SerializeField] private AudioSource _source;
    void Start()
    {
        StartCoroutine(Tiempo());
    }


    void Update()
    {
        barra.fillAmount = barraActual / barraMax;

        if(barraActual > 0 && barraActual < 50)
        {
            Debug.Log("Baja");
        }
        if(barraActual >= barraMax)
        {
           Debug.Log("GANASTE");
            menuPausa.SetActive(true);
            _source.Pause();
        }
    }

   IEnumerator Tiempo()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            if(barraActual < 50 && barraActual > 0)
            {
                barraActual -= 0.5f;
            }
        }
    }
   
}
