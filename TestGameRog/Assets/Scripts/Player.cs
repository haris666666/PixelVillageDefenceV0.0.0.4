using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]  private Joystick Joystick;
    [SerializeField]  private float Speed;



    private Animator Anim;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    private bool facingRight = true;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
     void Update()
    {
        moveInput = new Vector2(Joystick.Horizontal, Joystick.Vertical);
        moveVelocity = moveInput.normalized * Speed;
        if (moveInput.x == 0)
        {
            Anim.SetBool("running", false);
        }
        else
        {
            Anim.SetBool("running", true);
        }
        if (!facingRight && moveInput.x > 0)
        {
            flip();
        }
        if (facingRight && moveInput.x < 0)
        {
            flip();
        }
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
    private void flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
