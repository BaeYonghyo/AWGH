using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronBarOpen : MonoBehaviour
{
    bool down;

    public void Play()
    {
        down = true;
        Debug.Log("door opened");
    }

    void Update()
    {
        if (down)
        {
            transform.Translate(new Vector3(0, -7, 0));
        }
    }
}
