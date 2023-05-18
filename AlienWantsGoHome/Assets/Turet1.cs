using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turet1 : MonoBehaviour

{
    [SerializeField] Transform m_tfGunBody = null;
    [SerializeField] float m_range = 0f;
    [SerializeField] LayerMask m_layerMask = 0;
    [SerializeField] float m_spinSpeed = 0f;
    [SerializeField] float m_fireRate = 0f;
    public Transform bulletPos;
    public GameObject bullet;
    float m_currentFireRate;
    float timer;
    int waitingTime;
    float minus;
    GameObject vkswjd1;
    public vkswjd1 AAA;
    





    Transform m_tfTarget = null;

    void SearchEnemy()
    {
        Collider[] t_cols = Physics.OverlapSphere(transform.position, m_range, m_layerMask);
        Transform t_shortestTarget = null;

        if (AAA.cheking == true)
        {
            float t_shortestDistance = Mathf.Infinity;
            foreach (Collider t_colTarget in t_cols)
            {
                float t_distance = Vector3.SqrMagnitude(transform.position - t_colTarget.transform.position);
                if (t_shortestDistance > t_distance)
                {
                    t_shortestDistance = t_distance;
                    t_shortestTarget = t_colTarget.transform;
                }
            }
        }
        m_tfTarget = t_shortestTarget;
    }

    void Shot()
    {
        GameObject intantBullet = Instantiate(bullet, bulletPos.position, bulletPos.rotation);
        Rigidbody bulletRigid = intantBullet.GetComponent<Rigidbody>();
        bulletRigid.velocity = bulletPos.forward * 50;
    }

    // Start is called before the first frame update
    void Start()
    {
        AAA = GameObject.Find("vkswjd1").GetComponent<vkswjd1>();
        minus = -1.0f;
        InvokeRepeating("SearchEnemy", 0f, 0.5f);
        m_currentFireRate = m_fireRate;
        timer = 0.0f;
        waitingTime = 2;
        

    }

    // Update is called once per frame
    void Update()
    {
        if (m_tfTarget == null)
        {
            m_tfGunBody.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
        }
        else
        {
            Quaternion t_lookRotation = Quaternion.LookRotation(m_tfTarget.position - m_tfGunBody.position);
            Vector3 t_euler = Quaternion.RotateTowards(m_tfGunBody.rotation, t_lookRotation, m_spinSpeed * Time.deltaTime).eulerAngles;

            
            m_tfGunBody.rotation = Quaternion.Euler(0, t_euler.y, 0);

            Quaternion t_fireRotation = Quaternion.Euler(0, t_lookRotation.eulerAngles.y, 0);
            if (Quaternion.Angle(m_tfGunBody.rotation, t_fireRotation) < 5f)
            {
                m_currentFireRate -= Time.deltaTime;
                if (m_currentFireRate <= 0)
                {
                    m_currentFireRate = m_fireRate;
                    timer += Time.deltaTime;

                    if (timer > waitingTime)
                    {
                        Shot();
                        timer = 0;
                    }
                    
                }

            }
        }
    }
}

