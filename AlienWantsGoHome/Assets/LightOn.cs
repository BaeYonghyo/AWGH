using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOn : MonoBehaviour
{
    bool _on;

    public void On()
    {
        _on = true;
    }

    void Update()
    {
        if (_on)
        {
            Destroy(this.gameObject);
        }
    }
}
