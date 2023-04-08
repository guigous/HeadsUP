using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movimento;
    public float moveSpeed;
    public float jumpHeight;
    public int pulosExtras = 1;
    private float direction;
    

    public Animator anim;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;

    public bool floor;
    public LayerMask floorMask;

    



    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    public void SetMoviment(InputAction.CallbackContext value)
    {
        movimento = value.ReadValue<Vector2>();
        
    }
    public void SetJump(InputAction.CallbackContext value)
    {
        rb.velocity = Vector2.up * jumpHeight;
    }

    private void FixedUpdate()
    {

        Walking();

        if (IsGrounded() == true )
        {
            Debug.Log(IsGrounded());

        }
        if (IsGrounded() == false)
        {
            Debug.Log(IsGrounded());
        }






    }
    private void Walking()
    {
        transform.Translate(movimento.x, 0f, 0f);
        
        if (rb.angularVelocity != 0)
        {
            anim.SetBool("taCorrendo", true);
        }
        else
        {
            anim.SetBool("taCorrendo", false);
        }
        if(movimento.x < 0f)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
        if (movimento.x > 0f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        //Debug.Log(movimento);

    }
    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.down, boxCollider2D.bounds.extents.y + 0.1f, floorMask);
        Color rayColor;
        

        if (hit.collider != null)
        {
            rayColor = Color.green;
            
            
        }
        else
        {
            rayColor = Color.red;
            
        }
        //Debug.Log(hit.collider);
        Debug.DrawRay(boxCollider2D.bounds.center, Vector2.down * (boxCollider2D.bounds.extents.y + 0.2f), rayColor);
        return hit.collider != null;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.collider != null && CompareTag("floor"))
        {
            Debug.Log("here");
        }
    }
}
