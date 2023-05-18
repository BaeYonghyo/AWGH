using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetKey : MonoBehaviour
{
    public GameObject Target;
    public GameObject LightSign;
    public GameObject Light1, Light2;
    private new AudioSource audio3;
    public AudioClip solveSound;
    bool _on;

    public void Start()
    {
        this.audio3 = this.gameObject.AddComponent<AudioSource>();
        this.audio3.clip = this.solveSound;
        this.audio3.loop = false;
        _on = false;
    }

    public void On()
    {
        _on = true;
    }

    public void Update()
    {
        if (_on)
        {
            this.audio3.Play();
            LightSign.gameObject.SetActive(true);
            Target.SendMessage("Play");
            Light1.SendMessage("On");
            Light2.SendMessage("On");
            Destroy(this.gameObject);
        }
    }
}
