 // PlayerControl.cs
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerControl : MonoBehaviour
{

    bool isJump;
    private float power;
    public float POWERPLUS = 300.0f;
    private AudioSource audio;
    Animator anim;
    public AudioClip jumpSound;
    public AudioClip jumpSound2;

    // Start is called before the first frame update
    void Start()
    {
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.jumpSound;
        this.audio.loop = false;
    }

    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
       

        if (Input.GetKey(KeyCode.Space) && !isJump)
        { // 왼쪽 버튼이 눌려있는 동안
            power += POWERPLUS * Time.deltaTime; // 힘을 비축
            this.audio.PlayOneShot(this.jumpSound);
            anim.SetBool("isJump", true);
            anim.SetTrigger("doJump");
        }
        if (Input.GetKeyUp(KeyCode.Space))
        { // 왼쪽 버튼을 놓으면
          // 비축한 힘을 x와 y에 반영해서 오른쪽 위로 점프!
            this.audio.Stop();
            this.audio.PlayOneShot(this.jumpSound2);
            this.audio.PlayOneShot(this.jumpSound2);
            this.audio.PlayOneShot(this.jumpSound2);
            this.audio.PlayOneShot(this.jumpSound2);
            this.audio.PlayOneShot(this.jumpSound2);
            
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, power, 0));
            
            power = 0.0f; // 힘을 0으로

        }


        

        // 지면보다 아래(-5.0f)로 떨어지면
        if (this.transform.position.y < -5.0f)
        {
            SceneManager.LoadScene("Main"); // 씬을 다시 로드
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            anim.SetBool("isJump", false);
            isJump = false;


        }
    }
}