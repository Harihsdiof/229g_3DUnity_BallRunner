using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WinScreen : MonoBehaviour
{
    public GameObject winScreenUI; // ระบุ UI Canvas ที่มีหน้าจอชนะ
    public float delay;
    private void Start()
    {
        winScreenUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            winScreenUI.SetActive(true);
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown ()
    {
        yield return new WaitForSeconds (delay);
        SceneManager.LoadScene(2);
    }
}