using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate : MonoBehaviour
{
    public GameObject slimeChunk1;
    public GameObject slimeChunk2;
    public GameObject slime1;
    public GameObject slime2;
    public GameObject glass1;
    public GameObject glass2;
    public GameObject glass3;
    public GameObject timerImg;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            slimeChunk1.SendMessage("On");
            slimeChunk2.SendMessage("On");
            glass1.gameObject.SetActive(false);
            glass2.gameObject.SetActive(false);
            glass3.gameObject.SetActive(false);
            slime1.gameObject.SetActive(true);
            slime2.gameObject.SetActive(true);
            timerImg.gameObject.SetActive(true);
            timerImg.SendMessage("On");
        }
    }
}
