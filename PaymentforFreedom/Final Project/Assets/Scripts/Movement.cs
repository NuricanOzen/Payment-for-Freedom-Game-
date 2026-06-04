
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 7f;

    [Header("UI References")]
    public GameObject losePanel;
    private Vector2 moveInput;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;

    private bool isGrounded;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        if (value.isPressed && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

    private void Update()
    {

         if (transform.position.y < -40f)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0f;
            this.enabled = false;
            return; 
        }

        float moveX = moveInput.x;

        rb.linearVelocity = new Vector2(moveX * speed, rb.linearVelocity.y);

        animator.SetFloat("Speed", Mathf.Abs(moveX));

        if (moveX > 0.1f)
        {
            spriteRenderer.flipX = false;
        }
        else if (moveX < -0.1f)
        {
            spriteRenderer.flipX = true;
        }
    }
}