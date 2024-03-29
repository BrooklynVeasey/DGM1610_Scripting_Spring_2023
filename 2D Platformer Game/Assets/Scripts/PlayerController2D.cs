using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{

    //Player stats
    [Header("Player Stats")]
    public float speed; //How fast player moves
    public float jumpForce; //How high player jumps
    private float moveInput; //Get move input value

    //Player Rigidbody
    [Header("Rigidbody Component")]
    private Rigidbody2D rb;
    private bool isFacingRight =true;

    //Playr Jump
    [Header("Player Jump Settings")]
    private bool isGrounded = true;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public bool doubleJump;

    [Header("Animations")]
    private Animator playerAnim;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnim = GetComponent<Animator>();
    }

    //Fixed Update is caled a fixed  or set number of frames. This works best with physics based movement
    void FixedUpdate()
    {
        if(moveInput > 0 || moveInput < 0)
        {
            playerAnim.SetBool("isWalking", true);
        }

        else
        {
            playerAnim.SetBool("isWalking", false);
        }

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); //Define what is ground

        moveInput = Input.GetAxis("Horizontal"); //Get horizontal keybinding which will return a value between -1 and 1
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        //If player is moving right but facing left flip the player right
        if(!isFacingRight && moveInput >0)
        {
            FlipPlayer();
        }
        //If player is moving left but facing right flip the player left
        else if(isFacingRight && moveInput <0)
        {
            FlipPlayer();
        }
    }

    void FlipPlayer()
    {
        isFacingRight = !isFacingRight;
        Vector3 scaler = transform.localScale; //Local variable that stores localscale value
        scaler.x *= -1; //Flip the sprite graphic
        transform.localScale = scaler;
    }

    // Update is called once per frame
    void Update()
    {
        if(isGrounded)
        {
            doubleJump = true;
        }

        if(Input.GetKeyDown(KeyCode.Space) && doubleJump)
        {
            rb.velocity = Vector2.up * jumpForce; //makes the player jump
            doubleJump = false;
            playerAnim.SetTrigger("Jump_Trig");
        }

        else if (Input.GetKeyDown(KeyCode.Space) && !doubleJump && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
            playerAnim.SetTrigger("Jump_Trig");
        }
    }

}
