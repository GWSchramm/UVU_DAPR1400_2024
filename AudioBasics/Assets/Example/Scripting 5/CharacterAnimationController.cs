using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    public CharacterController controller;
    private Animator animator;
    private readonly int 
        run = Animator.StringToHash("Run"),
        idle = Animator.StringToHash("Idle"),
        jump = Animator.StringToHash("Jump"),
        wallJump = Animator.StringToHash("WallJump");

    private void Start()
    {
        // Cache the Animator component attached to CharacterArt
        animator = GetComponent<Animator>();

        //controller in parent object
        controller = GetComponentInParent<CharacterController>();
    }

    private void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        float horizontalMove = Input.GetAxisRaw("Horizontal");

        //if you are on the ground and you push jump then run the jump animation
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            animator.SetBool(jump, true);
          
        }
        else if (controller.isGrounded && animator.GetBool("Jump"))
        {
            animator.SetBool(jump, false);
        }

        //if you press jump while already in the air trigger the double jump
        //if(Input.GetButtonDown("jump") & !controller.isGrounded)
       // {
      //      animator.SetTrigger("DoubleJump");
       // }


        if (Mathf.Abs(horizontalMove) > 0)
        {
            animator.SetBool(run, true);
            animator.SetBool(idle, false);
        }
        else
        {
            animator.SetBool(run, false);
            animator.SetBool(idle, true);
        }
    }
}