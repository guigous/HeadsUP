using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teste : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movimento;
    public float moveSpeed;
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
        rb.AddForce(new Vector2(movimento.x, movimento.y) * Time.fixedDeltaTime * moveSpeed);
    }

    public void SetJump(InputAction.CallbackContext value)
    {
        rb.AddForce(Vector3.up * 100);
    }
}

