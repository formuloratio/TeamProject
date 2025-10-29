using UnityEngine;

public class BaseController : MonoBehaviour
{

    [Header("Movement Settings")]
    [SerializeField] protected float moveSpeed = 5f;
    [SerializeField] protected float jumpForce = 5f;
    [SerializeField] protected LayerMask groundLayer;//�ٴ� ������ ���̾�
    [SerializeField] protected float groundCheckDistance = 0.2f; // �ٴڰ��� �Ÿ���

    protected Rigidbody2D rb;
    protected SpriteRenderer sr;
    protected Animator anim;

    protected bool isGrounded = false;
    protected bool isActive = false;

    //�Է°� ����
    private float moveInput;
    private bool jumpPressed;

    //�������� ����
    private float jumpCooldown = 0.1f;
    private float jumpTimer = 0f;

    protected virtual void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponentInChildren<Animator>();
    }

    public void SetActive(bool value)
    {
        isActive = value;
        rb.velocity = Vector2.zero; //��ȯ�� ���� 0 
    }

    protected virtual void Update()
    {
        if (!isActive) return;

        //�Է°���
        moveInput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.W))
            jumpPressed = true;

        UpdateAnimation();
    }

    protected virtual void FixedUpdate()
    {
        if (!isActive) return;

        if (jumpTimer > 0)
            jumpTimer -= Time.fixedDeltaTime;
        //�ٴڰ���
        CheckGround();
        //�̵�
        Move();

        //����
        if (jumpPressed && isGrounded && jumpTimer <= 0)
        {
            Jump();
            jumpPressed = false;
            jumpTimer = jumpCooldown; // �����ϰ� 0.1�ʰ� �ٴڰ��� X
        }
    }

    protected virtual void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);

        if (x != 0)
            sr.flipX = x < 0;
    }

    protected virtual void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        isGrounded = false;
    }

    protected virtual void CheckGround()
    {
        //ĳ���� �Ʒ��� ���� ���

        float extraHeight = 0.2f;

        Vector2 FootRay = new Vector2(transform.position.x, transform.position.y - (GetComponent<Collider2D>().bounds.extents.y));

        RaycastHit2D hit = Physics2D.Raycast(FootRay, Vector2.down, extraHeight, groundLayer);
        isGrounded = hit.collider != null;

        // ����׿� ���� ǥ�� 
        Color color = isGrounded ? Color.green : Color.red;
        Debug.DrawRay(FootRay, Vector2.down * extraHeight, color);
    }

    protected virtual void UpdateAnimation()
    {
        if (anim == null) return;
        anim.SetBool("isMove", Mathf.Abs(rb.velocity.x) > 0.1f);
        anim.SetBool("isJump", !isGrounded);
    }


}

