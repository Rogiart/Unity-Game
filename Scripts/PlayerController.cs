using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 30f;

    public Sprite standSprite;
    public Sprite runSprite;
    public Sprite crouchSprite;

    public bool isCrouching = false;

    private SpriteRenderer sr;
    private BoxCollider2D box;
    private Rigidbody2D rb;

    private Vector3 originalScale;

    private bool isGrounded = true;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        originalScale = transform.localScale;

        sr.sprite = standSprite;
    }

    void Update()
    {
        // 左右移動
        float x = Input.GetAxisRaw("Horizontal");

        transform.Translate(
            x * speed * Time.deltaTime,
            0,
            0
        );

        // 左右反転
        if (x > 0)
        {
            transform.localScale = new Vector3(
                Mathf.Abs(originalScale.x),
                originalScale.y,
                originalScale.z
            );
        }

        if (x < 0)
        {
            transform.localScale = new Vector3(
                -Mathf.Abs(originalScale.x),
                originalScale.y,
                originalScale.z
            );
        }

        // ジャンプ（↑キー）
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                jumpForce
            );

            isGrounded = false;
        }

        // しゃがみ
        if (Input.GetKey(KeyCode.DownArrow))
        {
            isCrouching = true;

            sr.sprite = crouchSprite;

            box.size = new Vector2(3f, 1.5f);
        }
        else
        {
            isCrouching = false;

            box.size = new Vector2(3f, 3f);

            // 走る
            if (x != 0)
            {
                sr.sprite = runSprite;
            }
            // 立つ
            else
            {
                sr.sprite = standSprite;
            }
        }
    }

    // 障害物に当たったらゲームオーバー
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            GameManager gm =
                FindFirstObjectByType<GameManager>();

            if (gm != null)
            {
                gm.GameOver();
            }
        }
    }

    // 地面に着地したら再びジャンプ可能
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}