using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBCharacterController : MonoBehaviour
{

    public float rbMoveSpeed = 5f;
    private Rigidbody rb;
    private Vector3 rbMovementVector = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ;

    }

    // Update is called once per frame
    void Update()
    {
        RbMoveCharacter();

       
    }

    private void RbMoveCharacter()
    {
        float moveX = Input.GetAxis("Horizontal");
        rbMovementVector = new Vector3(moveX, 0f, 0f) * rbMoveSpeed;
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector3(rbMovementVector.x, rb.linearVelocity.y, 0f); // Keep physics-based movement and maintain Y velocity for gravity
    }



}

