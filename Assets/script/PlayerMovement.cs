using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private Animator anim;
    [SerializeField] private LayerMask jumpableGround;
    private SpriteRenderer sprite;
    public float jumpAmount = 10;
    private float dirX;
    public float speed = 5f;
    private enum MovementState{idle, running, jumping, falling}
    private MovementState state = MovementState.idle;

    [SerializeField] AudioSource jumpesound;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }
    
    void Update()
    {

        dirX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dirX * speed, rb.velocity.y);


        if(Input.GetButtonDown("Jump") && IsGrounded())
        {
            jumpesound.Play();
            rb.velocity = new Vector2(rb.velocity.y, jumpAmount);
            
        }
        animeUpdate();
        
        
    //     if (Input.GetKeyDown(KeyCode.Space))
    // {
    //     rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
    // }
    }
    public void animeUpdate()
    {
        MovementState state;

         if(dirX>0f)
        {
            state = MovementState.running;
            sprite.flipX = false;
            
        }
         else if(dirX<0f)
        {
            state = MovementState.running;
            sprite.flipX = true;
            
        }
         else
        {
            state = MovementState.idle;

        }
         if(rb.velocity.y > 0.1)
        {
            state = MovementState.jumping;
        }
         else if( rb.velocity.y < -0.1)
        {
            state = MovementState.falling;
        }
        anim.SetInteger("state", (int)state);
       

    }
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }


}
