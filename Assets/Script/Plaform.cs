using UnityEngine;

public class Platform : MonoBehaviour
{
    public float jumpForce = 10f;
    AudioManager audioManager;
    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        // Only bounce if the player is falling downward
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                audioManager.PlaySFX(audioManager.Jump);
                Vector2 velocity = rb.linearVelocity;
                velocity.y = jumpForce;
                rb.linearVelocity = velocity;
            }
        }
    }
}
