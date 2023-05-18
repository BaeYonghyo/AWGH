using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Evnet1 : MonoBehaviour
{
    GameObject Player;
    public bool isPlayerEnter /*,key1*/, key2;
    GameObject greenbox;
    GameObject redbox;
    GameObject key;
    
    void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        greenbox = GameObject.Find("greenbox");
        isPlayerEnter = false;
        //key1 = false;
        key2 = false;
        
    }

    void Update()
    {
        if(GameObject.Find("Button_Org").GetComponent<Button_Evnet>().key == true && isPlayerEnter == true && Input.GetKeyDown(KeyCode.E))
        {
            greenbox.gameObject.SetActive(false);
            key2 = true;
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
