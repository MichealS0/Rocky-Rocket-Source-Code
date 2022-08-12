using UnityEngine;
using UnityEngine.SceneManagement;

public class rockeyMovement : MonoBehaviour
{
    // Variables
    private float gravity;
    private Vector2 startPos;
    public bool dead;

    // Refrences
    public Rigidbody2D rb;
    public BarrierSpawnner spawnner;
    public Renderer rend;
    public MainMen menStart;
    public ScoreScrpt sc;
    public static rockeyMovement Instance { get; private set; }

    void Start()
    {
        Instance = this;
        startPos = transform.position;
        rb = GetComponent<Rigidbody2D>();
        gravity = rb.gravityScale;
        rb.gravityScale = 0;

        rend = GetComponent<Renderer>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        dead = true;
        gravity = rb.gravityScale;
        rb.gravityScale = 0;
        startPos = transform.position;
        SceneManager.LoadScene(0);

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Collider>().tag == "scoreIncrease")
        {
            sc.score += 1;
            Debug.Log(sc.score);
        }
    }

    void Update()
    {
        if (spawnner.StartedGame)
        {
            rb.gravityScale = 2;
        }
        if (spawnner.StartedGame == false)
        {
            transform.position = new Vector2(0, 0);
        }
        

        Vector2 vel = rb.velocity;
        float ang = Mathf.Atan2(vel.y, 10) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, ang - 90f));
        

        if (Input.GetButton("Jump"))
        {
            rb.AddForce(Vector2.up * gravity * Time.deltaTime * 1000f);
        }
    }
}
