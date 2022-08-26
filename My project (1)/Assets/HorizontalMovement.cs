using UnityEngine;

public class HorizontalMovement : MonoBehaviour
{
    public Rigidbody2D rb;


    public float speed = 15f;
    public float limit = 6f;


    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPos = rb.position + Vector2.right * x;

        newPos.x = Mathf.Clamp(newPos.x, -limit, limit);

        rb.MovePosition(newPos);
    
    }
}
