using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectable : Collectable
{
    public Sprite emptyChest;
    public int pesosAmount = 5;
    public bool cogido;


    protected override void OnCollect()
    {
        if (!collected && Input.GetKeyDown(KeyCode.E))
        {
            GameManager.instance.CogerItem();
            Destroy(this.gameObject);
            collected = true;
            cogido = true;
           // GetComponent<SpriteRenderer>().sprite = emptyChest;
            Debug.Log("Laurel");
        }
    }
}
