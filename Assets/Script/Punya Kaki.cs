using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PunyaKaki : MonoBehaviour
{
    public float movementSpeed = 10f;
    Rigidbody2D rb;
    float movement = 0f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.linearVelocity; 
        velocity.x = movement;
        rb.linearVelocity = velocity;
    }
}
