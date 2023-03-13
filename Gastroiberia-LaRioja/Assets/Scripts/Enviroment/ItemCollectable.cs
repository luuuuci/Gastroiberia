using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectable : Collectable
{
    public Sprite emptyChest;
    public int pesosAmount = 5;


    protected override void OnCollect()
    {
        if (!collected && Input.GetKeyDown(KeyCode.E))
        {
            Destroy(this.gameObject);
            collected = true;
           // GetComponent<SpriteRenderer>().sprite = emptyChest;
            Debug.Log("Laurel");
        }
    }
}
