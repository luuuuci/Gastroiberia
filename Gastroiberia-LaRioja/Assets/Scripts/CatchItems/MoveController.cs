using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoveController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed, jumpForce;
    private bool moveLeft, moveRight;
    public int CoinValue;
    public TextMeshProUGUI text;
    [SerializeField] GameObject menuPausa;
    [SerializeField] GameObject fruta;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveSpeed = 5f;
        jumpForce = 500f;
        moveLeft = false;
        moveRight = false;
        CoinValue = 0;
    }
    public void MoveLeft()
    {
        moveLeft = true;
    }
    public void MoveRight()
    {
        moveRight = true;
    }
    public void Jump()
    {
        if(rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * jumpForce);
        }
    }
    public void StopMoving()
    {
        moveLeft = false;
        moveRight = false;
        rb.velocity = Vector2.zero;
    }
    // Update is called once per frame
    void Update()
    {
        if (moveLeft)
        {
            rb.velocity = new Vector2(-moveSpeed, 0f);
        }

        if (moveRight)
        {
            rb.velocity = new Vector2(moveSpeed, 0f);
        }
        if(CoinValue == 10)
        {
            Debug.Log("YOU WIN");
            menuPausa.SetActive(true);
            fruta.SetActive(false);


        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
            CoinValue++;
            
            text.text = "X" + CoinValue.ToString();
        }
    }
}
