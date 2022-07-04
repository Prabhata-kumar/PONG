using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    public float speed = 2000f;
    public new Rigidbody2D rigidbody;
   // private Vector2 direction;


    public void Start()
    {
        AddStartingForce();
    }

    public void ResetPosition()
    {
      /*  float x = Random.value < 0.5f ? -1f : 1f;

        float y = Random.value < 0.5f ? Random.Range(-1f, -0.5f)
                                      : Random.Range(0.5f, 1f);
        Vector2 direction = new Vector2(x, y);
        rigidbody.AddForce(direction * speed);*/

         rigidbody.velocity = Vector2.zero;
         rigidbody.position = Vector2.zero;
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
        rigidbody.AddForce(direction * speed);
    }

}
