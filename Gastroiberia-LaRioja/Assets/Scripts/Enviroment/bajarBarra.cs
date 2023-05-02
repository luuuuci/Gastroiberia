using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bajarBarra : MonoBehaviour
{
    public Rigidbody2D rb;
    public SpriteRenderer sprRend;
    public float bajar;
    public GameObject objectToDestroy;
    public GameObject objectAparecer;
    
    // Start is called before the first frame update
    void Awake()
    {
        //
        sprRend.drawMode = SpriteDrawMode.Sliced;

       // rb = gameObject.AddComponent<Rigidbody2D>() as Rigidbody2D;
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    void Start()
    {
        //objectToDestroy = GameObject.Find("balon");
        //objectAparecer = GameObject.Find("pez");
        bajar = 0.25f;
        gameObject.transform.Translate(0.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        //Debug.Log("Sprite size: " + sprRend.size.ToString("F2"));
        //Press the Space key to increase the size of the sprite
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sprRend.size += new Vector2(-bajar, 0.00f);
            
            
        }
        if(sprRend.size.ToString("F2") == "(0.00, 1.00)" ){
            Debug.Log("HECHO");
            objectAparecer.SetActive(true);
            Destroy(objectToDestroy);
            


        }
    }
}
