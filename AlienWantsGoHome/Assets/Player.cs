using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody rigid;
    Animator animator;

    private float distance;
    private new AudioSource audio;
    private new AudioSource audio2;
    public bool isJump = false;
    public int reverse = 1;
    public float forceGravity = -2.0f;
    public float moveSpeed;
    public Slider hpBar;
    public AudioClip jumpSound;
    public AudioClip healSound;
    public GameObject press;
    public GameObject status;
    public GameObject status_key;
    public GameObject goldKey;
    //public GameObject drug;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        animator = GetComponentInChildren<Animator>();

        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio2 = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.jumpSound;
        this.audio2.clip = this.healSound;
        this.audio.loop = false;
        this.audio2.loop = false;
    }

    void Update()
    {
        Move();
        Jump();
        Ymax();
        Animation();
        rigid.AddForce(Vector3.down * forceGravity * reverse);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (az) az.Run();
        }
    }

    void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        transform.Rotate((new Vector3(0, hor, 0) * moveSpeed) * Time.deltaTime * 16);
        transform.Translate((new Vector3(0, 0, ver) * moveSpeed) * Time.deltaTime);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJump == false)
        {
            this.audio.Play();
            if (isJump == false)
            {
                transform.Translate(new Vector3(0, 1, 0));
                isJump = true;
                reverse *= -1;
            }
            else transform.Translate(new Vector3(0, -1, 0));
            transform.Rotate(new Vector3(180, 180, 0));
        }
    }

    void Ymax()
    {
        if(this.transform.position.y == 15)
        {
            reverse *= -1;
        }
    }

    void Animation()
    {
        if (Input.GetKey(KeyCode.W)) animator.SetBool("walkFwd", true);
        else animator.SetBool("walkFwd", false);
        if (Input.GetKey(KeyCode.S)) animator.SetBool("walkBwd", true);
        else animator.SetBool("walkBwd", false);
    }

    void Damaged()
    {
        if (hpBar.value > 0)
        {
            hpBar.value -= .34f;
        }
        else SceneManager.LoadScene("Lose");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJump = false;
            Time.timeScale = 1.0f;
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Damaged();
        }
        if (collision.gameObject.CompareTag("GoldKey"))
        {
            goldKey.SendMessage("On");
        }
    }

    public ActionZone az;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "ActionZone")
        {
            press.gameObject.SetActive(true);
            az = col.gameObject.GetComponent<ActionZone>();
        }
        if(col.gameObject.tag == "Fire" )
        {
            Damaged();
            az = null;
        }
        if(col.gameObject.tag == "Goal")
        {
            SceneManager.LoadScene("Win");
        }
        if(col.gameObject.tag == "Drug")
        {
            this.audio2.Play();
            hpBar.value = 1.0f;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "ActionZone")
        {
            press.gameObject.SetActive(false);
            az = null;
        }
    }
}