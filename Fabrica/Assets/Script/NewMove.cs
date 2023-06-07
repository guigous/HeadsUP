using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Pun.UtilityScripts;
using Photon.Realtime;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using Unity.VisualScripting;

public class NewMove : MonoBehaviourPunCallbacks
{
    private Rigidbody2D rb;
    private Vector2 movimento;
    public float moveSpeed;
    public float jumpHeight;
    public PhotonView photonView;

   

    public AudioClip somPulo;


    public Animator anim;
    private BoxCollider2D boxCollider2D;
    private PlayerInput playerInput;

    public bool floor;
    public LayerMask floorMask;


    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


    /*private void OnEnable()
    {
        playerInput.actions["Jump"].performed += SetJump;

    }*/




    
    void Awake()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        boxCollider2D = GetComponent<BoxCollider2D>();
        playerInput = GetComponentInParent<PlayerInput>();
        photonView = GetComponentInParent<PhotonView>();

    }
    

    

    /*public void SetMoviment(InputAction.CallbackContext value)
    {
        
        
            movimento = value.ReadValue<Vector2>();
        
        

    }
    public void SetJump(InputAction.CallbackContext value)
    {
        
        if (IsGrounded() == true)
        {
            rb.velocity = Vector2.up * jumpHeight;
            audioSource.PlayOneShot(somPulo);
        }

    }*/

    private void FixedUpdate()
    {
        Walking();

    }
    public void Walking()

    {
        if (photonView.IsMine)
        {
            float movimentoHorizontal = Input.GetAxis("Horizontal");
            Vector3 movimento = new Vector3(movimentoHorizontal, 0f, 0f) * moveSpeed * Time.deltaTime;
            transform.Translate(movimento);
            WalkingAnim();

            if (Input.GetButtonDown("Jump")&& IsGrounded() == true)
            {
                rb.velocity = Vector2.up * jumpHeight;
                JumpingAnim();
            }

            bool IsGrounded()
            {
                RaycastHit2D hit = Physics2D.Raycast(boxCollider2D.bounds.center, Vector2.down, boxCollider2D.bounds.extents.y + 0.5f, floorMask);


                if (hit.collider != null)
                    return true;
                else
                    return false;

            }

            void JumpingAnim()
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
            void WalkingAnim()
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
                if (movimento.x < 0f)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                }
                if (movimento.x > 0f)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                }



            }
        }


    }

    

    /*public void JumpingAnim()
    {
        if (IsGrounded() == false)
        {
            anim.SetBool("taPulando", true);
        }
        if (IsGrounded() == true)
        {
            anim.SetBool("taPulando", false);
        }
    }*/
    

    
    /*private void OnDisable()
    {
        playerInput.actions["Jump"].performed -= SetJump;
    }*/
}
