using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    public GameObject hitSound;
    public float speed = 2000f;
    public Rigidbody2D rb;
    public Vector2 testForce;

    public void ResetPosition()
    {
         rb.velocity = Vector2.zero;
         rb.position = Vector2.zero;
         AddStartingForce();
    }

    public void AddStartingForce()
    {
        //yield return WaitForSeconds(10);
        // Flip a coin to determine if the ball starts left or right
        float x = Random.value < 0.5f ? -1f : 1f;

        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f)
                                      : Random.Range(0.5f, 1f);

        // Flip a coin to determine if the ball goes up or down. Set the range
        // between 0.5 -> 1.0 to ensure it does not move completely horizontal.
        Vector2 direction = new Vector2(x, y);
       // Debug.Log("Ball Direction: " + direction);
        rb.velocity = Vector2.zero;
        //rigidbody.velocity = direction * speed;
        rb.AddForce(direction * speed);
       // Debug.Log("Ball velocity: " + (direction * speed));
    }

    public void OnCollisionEnter(Collision collision)
    {
        Instantiate(hitSound, transform.position, transform.rotation);
    }
}
