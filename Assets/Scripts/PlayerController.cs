using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 1f;
    private Rigidbody2D rb;
    private bool jumpPressed = false;
    public bool isDead = false;
    public GameObject deathEffect;
    private Animator animator;
    public GameObject jumpEffect;
    public GameObject[] players;
    void Start()
    {
        int playerIndex = PlayerPrefs.GetInt("Skin");
        players[playerIndex].gameObject.SetActive(true);
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jumpPressed = true;
            animator.SetTrigger("jump");
            Instantiate(jumpEffect, transform.position, Quaternion.identity);
        }
        
    }
    void FixedUpdate()
    {
        if (jumpPressed)
        {
            rb.linearVelocity = Vector2.zero;
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            jumpPressed = false;
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
            isDead = true;
            Instantiate(deathEffect, transform.position, Quaternion.identity);
        }
    }

}
