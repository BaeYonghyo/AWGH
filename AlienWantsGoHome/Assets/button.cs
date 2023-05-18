using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public bool isPlayerEnter;
    public GameObject press;

    void Awake()
    {
        isPlayerEnter = false;
    }

    void Update()
    {
        if (isPlayerEnter == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("fffff");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPlayerEnter = true;
            press.gameObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            press.gameObject.SetActive(false);
        }
    }
}
