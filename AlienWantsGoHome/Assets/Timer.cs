using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float maxTime;
    public Text text_Timer;
    public bool _on = false;

    void On()
    {
        _on = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_on)
        {
            maxTime -= Time.deltaTime;
            text_Timer.text = "00:" + Mathf.Round(maxTime);
            if (maxTime <= 0)
            {
                SceneManager.LoadScene("Lose");
            }
        }
    }
}
