using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerMovement : MonoBehaviour
{
    public float speed; // ความเร็วของการเคลื่อนที่

    private Rigidbody rb; // Rigidbody ของ Player

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // รับค่า Rigidbody จาก GameObject ที่ติดตั้ง Script นี้
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // รับค่าการกดปุ่มซ้าย-ขวา
        float moveVertical = Input.GetAxis("Vertical"); // รับค่าการกดปุ่มขึ้น-ลง

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // สร้าง Vector3 เพื่อเก็บการเคลื่อนที่ใหม่

        rb.AddForce(movement * speed); // เคลื่อนที่ Player โดยใช้ Force
    }
}
