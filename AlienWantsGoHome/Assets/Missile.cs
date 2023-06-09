using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    Rigidbody m_rigid = null;
    Transform m_tfTarget = null;

  
    [SerializeField] float m_speed = 0f;
    [SerializeField] LayerMask m_layerMask = 0;
    [SerializeField] ParticleSystem m_psEffect = null;
    float m_currentSpeed = 10f;
    private AudioSource audio;
    public AudioClip shotSound;

    void SearchEnemy()
    {
        Collider[] t_cols = Physics.OverlapSphere(transform.position, 100f, m_layerMask);

        if (t_cols.Length > 0)
        {
            m_tfTarget = t_cols[Random.Range(0, t_cols.Length)].transform;
        }
    }

    IEnumerator LaunchDelay()
    {
        yield return new WaitUntil(() => m_rigid.velocity.y < 0f);
        yield return new WaitForSeconds(0.1f);

        SearchEnemy();
       

        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }

    void Start()
    {
        m_rigid = GetComponent<Rigidbody>();
        StartCoroutine(LaunchDelay());
        this.audio = this.gameObject.AddComponent<AudioSource>();
        this.audio.clip = this.shotSound;
        this.audio.loop = false;
 


    }
    // Update is called once per frame
    void Update()
    {
        if (m_tfTarget != null)
        {
            if (m_currentSpeed <= m_speed)
            {
                m_currentSpeed += m_speed * Time.deltaTime;
            }
            transform.position += transform.up * m_currentSpeed * Time.deltaTime;
            Vector3 t_dir = (m_tfTarget.position - transform.position).normalized;
            transform.up = Vector3.Lerp(transform.up, t_dir, 0.25f);
            this.audio.PlayOneShot(this.shotSound);
        }

        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
