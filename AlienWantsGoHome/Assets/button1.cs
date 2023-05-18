using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class button1 : MonoBehaviour
{
    public bool isPlayerEnter;

    void Awake()
    {
    
        isPlayerEnter = false;
   
    }

    void Update()
    {
        if (isPlayerEnter == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("main3");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPlayerEnter = true;
            
        }
    }
   
}
