using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public int moveSpeed;
    private float direction;


    public Animator anim;

    private Vector3 facingRight;
    private Vector3 facingLeft;

    public bool taNoChao;
    public Transform detectaChao;
    public LayerMask oQueEChao;

    public int pulosExtras = 1;
    private Vector2 movement;

    private void Start()
    {
        facingRight = transform.localScale;
        facingLeft = transform.localScale;
        facingLeft.x = facingLeft.x * -1;

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        if (rb.angularVelocity != 0)
        {
            anim.SetBool("taCorrendo", true);
        }
        else
        {
            anim.SetBool("taCorrendo", false);
        }

        
        taNoChao = Physics2D.OverlapCircle(detectaChao.position, 0.2f, oQueEChao);

        if (Input.GetButtonDown("Jump") && taNoChao == true)
        {
            rb.velocity = Vector2.up * 25;

            anim.SetBool("taPulando", true);
        }
        if (Input.GetButtonDown("Jump") && taNoChao == false && pulosExtras > 0)
        {
            rb.velocity = Vector2.up * 27;
            anim.SetBool("taPulando", true);
            pulosExtras--;
        }

        if (taNoChao && rb.velocity.y == 0)
        {
            pulosExtras = 1;
            anim.SetBool("taPulando", false);
        }





        direction = Input.GetAxis("Horizontal");
        if (direction > 0)
        {
            transform.localScale = facingRight;
        }

        if (direction < 0)
        {
            transform.localScale = facingLeft;
        }


        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
    }

    public void SetMoviment(InputAction.CallbackContext value)
    {
        movement = value.ReadValue<Vector2>();
        
    }

    public void SetJump(InputAction.CallbackContext value)
    {
        rb.AddForce(Vector2.up * 100);
    }

    
}