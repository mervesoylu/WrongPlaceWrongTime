using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : physicsObject
{
    public float maxSpeed = 7;
    public float jumpTakeOffSpeed = 7;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            velocity.y = jumpTakeOffSpeed;
        }else if (Input.GetKeyUp(KeyCode.Space))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * .5f;
            }

            targetVelocity = move * maxSpeed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            targetVelocity.x = maxSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            targetVelocity.x = -maxSpeed;
        }

    }
}
