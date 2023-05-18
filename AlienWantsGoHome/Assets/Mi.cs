using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mi : MonoBehaviour
{
    [SerializeField] GameObject m_goMissile = null;
    [SerializeField] Transform m_tfMissileSpawn = null;
    // Start is called before the first frame update
    float Timer = 0.0f;
    float WaitingTime = 2f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;



        if (Timer > WaitingTime)
        {
            GameObject t_missile = Instantiate(m_goMissile, m_tfMissileSpawn.position, Quaternion.identity);
            t_missile.GetComponent<Rigidbody>().velocity = Vector3.up * 5f;

            //Action
            Timer = 0;

        }
    }
}
