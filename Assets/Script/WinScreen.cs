using System;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
    public GameObject winScreenUI; // ระบุ UI Canvas ที่มีหน้าจอชนะ

    private void Start()
    {
        winScreenUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            winScreenUI.SetActive(true);
        {
            
        }
    }
}