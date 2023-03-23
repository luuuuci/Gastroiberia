using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject Box;
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    public float moveSpeed = 2f;
    public Animator animator;
    public bool isMoving;
    

    [SerializeField] GameObject dialogueBox;


    // Start is called before the first frame update
    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        isMoving = true;

        

    }

    // Update is called once per frame
    private void Update()
    {
       if (isMoving == false)
            {
                return;
            }

        

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", x);
        animator.SetFloat("Vertical", y);
        animator.SetFloat("Speed", moveDelta.sqrMagnitude);

        //Reset moveDelta
        moveDelta = new Vector3(x, y, 0);

       

        // Make sure we can move in this direcion by casting a box first, if the box returns null, we are free to move
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //Move
            transform.Translate(0, moveDelta.y * (Time.deltaTime* moveSpeed), 0);
        }

        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));
        if (hit.collider == null)
        {
            //Move
            transform.Translate(moveDelta.x * (Time.deltaTime * moveSpeed), 0, 0);
        }


    }
}
