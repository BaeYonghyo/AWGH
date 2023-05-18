using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Slime_Chunk: MonoBehaviour
{
    NavMeshAgent nav;
    GameObject target;
    private float distance;
    private bool _on = false;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        target = GameObject.Find("Player");
    }

    void On()
    {
        _on = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (_on)
        {
            if (Vector3.Distance(target.transform.position, this.transform.position) <= 10.0f)
            {
                if (nav.destination != target.transform.position)
                {
                    nav.SetDestination(target.transform.position);
                }
                else
                {
                    nav.SetDestination(transform.position);
                }
            }
        }
    }
}
