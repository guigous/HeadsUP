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
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetMoviment(InputAction.CallbackContext value)
    {
        movimento = value.ReadValue<Vector2>();
        
    }

    private void FixedUpdate()
    {
        transform.Translate(movimento.x, 0, 0);

    }

    public void SetJump(InputAction.CallbackContext value)
    {
        rb.velocity = Vector2.up * jumpHeight;
    }

}
