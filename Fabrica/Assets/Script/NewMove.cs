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



    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        /*private void Flip()
    {
        facingRight = !facingRight;
        scale.x *= -1;
        transform.localScale = scale;
    }
        */
        floor = Physics2D.OverlapCircle(floorDetect.position, 0.2f, floorMask);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, 1f, floorMask);
        Debug.DrawRay(transform.position, Vector2.down * 10f, Color.red);

        if  (hit.collider != null)
        {
            

            anim.SetBool("taPulando", true);
         
            

        }
        if (rb.velocity.y > 0f && floor == false && pulosExtras > 0)
        {
            
            anim.SetBool("taPulando", true);
            pulosExtras--;
        }

        if (floor && rb.velocity.y == 0)
        {
            pulosExtras = 1;
            anim.SetBool("taPulando", false);
        }





        

    }

   

}
