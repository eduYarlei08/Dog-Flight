using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] float playerSpeed;

    Rigidbody2D rb;
    Vector2 playerDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
