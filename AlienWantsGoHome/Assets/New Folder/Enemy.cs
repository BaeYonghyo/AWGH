 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxHealth;
    public int curHealth;
    public Transform target;

    Material mat;
    Rigidbody rigid;
    BoxCollider boxCollider;
    NavMeshAgent nav;

    void Start()
    {

        Destroy(gameObject, 10f);

    }

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
        mat = GetComponentInChildren<MeshRenderer>().material;
        nav = GetComponent<NavMeshAgent>();
        

    }
   void Update()
    {
        nav.SetDestination(target.position);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Stair"))
        {
            Destroy(collision.gameObject);
            
        }
    }
}
