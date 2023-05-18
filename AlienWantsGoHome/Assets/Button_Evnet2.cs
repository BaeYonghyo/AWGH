using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset_Evnet2 : MonoBehaviour
{
    GameObject Player;
    bool isPlayerEnter;//,key1, key2;
    GameObject greenbox;
    GameObject redbox;
    GameObject key;

    void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        greenbox = GameObject.Find("greenbox");
        redbox = GameObject.Find("redbox");
        isPlayerEnter = false;
        //key1 = false;
        //key2 = false;
        
    }

    void Update()
    {
        if(isPlayerEnter == true && Input.GetKeyDown(KeyCode.E))
        {
            greenbox.gameObject.SetActive(true);
            redbox.gameObject.SetActive(true);
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
