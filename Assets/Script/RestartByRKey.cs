using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartByRKey : MonoBehaviour
{
    void Update()
    {
        // ตรวจสอบว่าผู้เล่นกดปุ่ม R บนคีย์บอร์ดหรือไม่
        if (Input.GetKeyDown(KeyCode.R))
        {
            // โหลดฉากปัจจุบันอีกครั้งเพื่อเริ่มเกมใหม่
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}