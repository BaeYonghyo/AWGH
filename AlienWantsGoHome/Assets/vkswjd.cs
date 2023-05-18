using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vkswjd : MonoBehaviour
{
    public bool cheking = false;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            cheking = true;
            Debug.Log("üŷüŷ!!!");
        }
    }

    void OnTriggerExit(Collider col)
    {
        cheking = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
