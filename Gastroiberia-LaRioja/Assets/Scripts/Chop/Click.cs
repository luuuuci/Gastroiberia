using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{

    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _chopClip;

    public BarraClick barraAct;
    void Start()
    {
        barraAct = FindObjectOfType<BarraClick>();

    }
    
    void OnMouseDown()
    {
        //Debug.Log(barraAct.barraActual);
        barraAct.barraActual = barraAct.barraActual + 3;
        _source.PlayOneShot(_chopClip);
    }
}
