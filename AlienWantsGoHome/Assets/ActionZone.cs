using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionZone : MonoBehaviour
{
    public GameObject Target;
    public GameObject LightSign;
    public GameObject Light1, Light2;
    private new AudioSource audio;
    public AudioClip solveSound;

    public void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.solveSound;
        this.audio.loop = false;
    }

    public void Run()
    {
        this.audio.Play();
        LightSign.gameObject.SetActive(true);
        Target.SendMessage("Play");
        Light1.SendMessage("On");
        Light2.SendMessage("On");
    }
}
