using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public GameObject Drug;
    public GameObject Player;
    public float regen = 0;
    public bool isAte = false;
    public float verRange = 2.0f;
    private float rotSpeed = 100f;
    private float timer = 0.0f;
    public float verSpeed = 0.5f;

    void Update()
    {
        if (!isAte)
        {
            timer += Time.deltaTime;
            Vector3 pos = Drug.transform.position;
            pos.y = 1.2f + verRange * Mathf.Sin(verSpeed * timer);
            Drug.transform.position = pos;
            Drug.transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
        }
        else
        {
            regen += 0.1f * Time.deltaTime;
            if(regen >= 1.0f)
            {
                Drug.gameObject.SetActive(true);
                regen = 0;
                isAte = false;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isAte)
        {
            if (other.tag == "Player")
            {
                timer = 0;
                isAte = true;
                Drug.gameObject.SetActive(false);
            }
        }
    }
}
