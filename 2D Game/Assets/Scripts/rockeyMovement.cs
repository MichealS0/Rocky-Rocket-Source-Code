using UnityEngine;

public class rockeyMovement : MonoBehaviour
{
    // Variables
    private float gravity;
    private Vector2 startPos;

    // Refrences
    public Rigidbody2D rb;

    public static rockeyMovement Instance { get; private set; }

    void Start()
    {
        Instance = this;
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        gravity = rb.gravityScale;    
    }

    void Update()
    {
        Vector2 vel = rb.velocity;
        float ang = Mathf.Atan2(vel.y, 10) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, ang - 90f));

        if (Input.GetButton("Jump"))
        {
            rb.AddForce(Vector2.up * gravity * Time.deltaTime * 2000f);
        }
    }
}
