using UnityEngine;

public class SmoothFollow : MonoBehaviour
{
    public Transform target; // ประกาศตัวแปรสำหรับเก็บ GameObject ที่ต้องการให้กล้องติดตาม
    public float smoothSpeed = 0.125f; // ความลื่นของการเคลื่อนที่ของกล้อง
    public Vector3 offset; // ตำแหน่งที่กล้องจะอยู่ต่อไปเมื่อติดตาม

    void LateUpdate()
    {
        // คำนวณตำแหน่งที่ต้องการให้กล้องติดตาม
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}