using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghlwjs2 : MonoBehaviour
{
    float rotSpeed = 100f;

    void Update()
    {
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime, 0));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Debug.Log("- ������ ȹ��");
            //Destroy(gameObject);
        }
    }
}
