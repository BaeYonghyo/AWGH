using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Evnet : MonoBehaviour
{
    GameObject Player;
    public bool isPlayerEnter, key;//, key1, key2;
    GameObject redbox;
    
    void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        redbox = GameObject.Find("redbox");
        isPlayerEnter = false;
        key = false;
        //key1 = false;
        //key2 = false;
    }

    void Update()
    {
        if(isPlayerEnter == true && Input.GetKeyDown(KeyCode.E))
        {
            redbox.gameObject.SetActive(false);
            key = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            isPlayerEnter = true;
            Debug.Log("¡¢√À»Æ¿Œ");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            isPlayerEnter = false;
        }
    }
}
