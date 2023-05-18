using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghlwjs1 : MonoBehaviour
{
    float rotSpeed = 70f;

    void Update()
    {
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("- æ∆¿Ã≈€ »πµÊ");
            //Destroy(gameObject);
        }
    }
}
