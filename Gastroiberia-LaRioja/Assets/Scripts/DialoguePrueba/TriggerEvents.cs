using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent onTriggerEnter;

    public UnityEvent onTriggerExit;

    void onTriggerEnter2D(Collider2D other){
        onTriggerEnter.Invoke();
    }
    void onTriggerExit2D(Collider2D other){
        onTriggerExit.Invoke();
    }
}
