using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // ความเร็วของการเคลื่อนที่
    public float jumpHeight; // ความสูงของการกระโดด
    public float jumpDistance; // ความยาวของการกระโดด
    public float jumpSmoothness; // ความราบรื่นในการกระโดด

    private Rigidbody rb;
    private Collider playerCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerCollider = GetComponent<Collider>();
    }

    void Update()
    {
        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jumpDirection = new Vector3(rb.velocity.x, 0.0f, rb.velocity.z).normalized;
            rb.velocity = new Vector3(rb.velocity.x, 0.0f, rb.velocity.z); // ลดความเร็วในแนวแกน y เป็น 0 เพื่อทำให้กระโดดไม่กระทบกับพื้น
            rb.AddForce(jumpDirection * jumpDistance, ForceMode.Impulse);
            float targetJumpHeight = Mathf.Sqrt(jumpHeight * -2f * Physics.gravity.y);
            rb.AddForce(Vector3.up * Mathf.Lerp(0, targetJumpHeight, jumpSmoothness), ForceMode.Impulse); // เพิ่มความราบรื่นในการกระโดด
        }
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, playerCollider.bounds.extents.y + 0.1f);
    }
}