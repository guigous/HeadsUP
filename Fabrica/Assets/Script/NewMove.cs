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

    public bool floor;
    public Transform floorDetect;
    public LayerMask floorMask;

    private Vector2 facingRight;
    private Vector2 facingLeft;
    private BoxCollider2D collider2D; 


    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<BoxCollider2D>();
    }

    public void SetMoviment(InputAction.CallbackContext value)
    {
        movimento = value.ReadValue<Vector2>();
        Debug.Log(movimento);

    }
    public void SetJump(InputAction.CallbackContext value)
    {
        rb.velocity = Vector2.up * jumpHeight;
    }

    private void FixedUpdate()
    {
        transform.Translate(movimento.x, 0, 0);
        if (movimento.x > 0f)
        {
            anim.SetBool("taCorrendo", true);
        }
        if (movimento.x == 0f)
        {
            anim.SetBool("taCorrendo", false);
        }
        if (movimento.x < 0f)
        {
            
        }

        if (IsGrounded() != null)
        {


         anim.SetBool("taPulando", true);



        }
       





        

    }

   private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(collider2D.bounds.center, Vector2.down, collider2D.bounds.extents.y + 0.1f, floorMask);
        Color rayColor;
        if(hit.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(collider2D.bounds.center, Vector2.down * (collider2D.bounds.extents.y + 0.1f), rayColor);
        Debug.Log(hit.collider);

        return hit.collider != null;
    }

}
