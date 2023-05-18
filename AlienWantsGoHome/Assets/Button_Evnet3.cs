using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Evnet3 : MonoBehaviour
{
    GameObject Player;
    bool isPlayerEnter;//,key1, key2;
    GameObject greenbox;
    GameObject redbox;
    GameObject yellowbox;
    //GameObject key;

    void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        greenbox = GameObject.Find("greenbox");
        yellowbox = GameObject.Find("yellowbox");
        isPlayerEnter = false;
        //key1 = false;
        //key2 = false;
        
    }

    void Update()
    {
        if(GameObject.Find("Button_Ppl").GetComponent<Button_Evnet1>().key2 == true && GameObject.Find("Button_Org").GetComponent<Button_Evnet>().key == true && isPlayerEnter == true && Input.GetKeyDown(KeyCode.E))
        {
            yellowbox.gameObject.SetActive(false);
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
