using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Normal_Npc : MonoBehaviour
{
    public DialogueTrigger trigger;

    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Player") == true){
         trigger.StartDialogue();
        }
       
    }
}
