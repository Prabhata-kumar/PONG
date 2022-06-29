using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPadal : MonoBehaviour
{
    public float Speed;
    public Rigidbody2D Ball;
    public Rigidbody2D Rigidbody;

    private void FixedUpdate()
    {
        // Check if the ball is moving towards the paddle (positive x velocity)
        // or away from the paddle (negative x velocity)
        if (Ball.velocity.x > 0f)
        {
            // Move the paddle in the direction of the ball to track it
            if (Ball.position.y > Rigidbody.position.y)
            {
                Rigidbody.AddForce(Vector2.up * Speed);
            }
            else if (Ball.position.y < Rigidbody.position.y)
            {
                Rigidbody.AddForce(Vector2.down * Speed);
            }
        }
        else
        {
            // Move towards the center of the field and idle there until the
            // ball starts coming towards the paddle again
            if (Rigidbody.position.y > 0f)
            {
                Rigidbody.AddForce(Vector2.down * Speed);
            }
            else if (Rigidbody.position.y < 0f)
            {
                Rigidbody.AddForce(Vector2.up * Speed);
            }
        }
    }


}
