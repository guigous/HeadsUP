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
    
    
    
    

    public Animator anim;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;
    private PlayerInput playerInput;

    public bool floor;
    public LayerMask floorMask;




    private void OnEnable()
    {
        playerInput.actions["Jump"].performed += SetJump;
        
    }

   


    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        playerInput = GetComponentInParent<PlayerInput>();


    }

    public void SetMoviment(InputAction.CallbackContext value)
    {
        movimento = value.ReadValue<Vector2>();
        
    }
    public void SetJump(InputAction.CallbackContext value)
    {
        if (IsGrounded() == true)
        {
            rb.velocity = Vector2.up * jumpHeight;
            
        }
        
    }

    private void FixedUpdate()
    {
        

        Walking();
        Jumping();

         





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

        

    }

    public void Jumping()
    {
        if (IsGrounded() == false)
        {
            anim.SetBool("taPulando", true);
        }
        if (IsGrounded() == true)
        {
            anim.SetBool("taPulando", false);
        }
    }
    

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.down, boxCollider2D.bounds.extents.y + 0.5f, floorMask);
        

        if (hit.collider != null)
            return true;
        else
            return false;
        
    }
    private void OnDisable()
    {
        playerInput.actions["Jump"].performed -= SetJump;
    }
}
