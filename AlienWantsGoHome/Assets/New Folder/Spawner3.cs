using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{

    public GameObject[] prefabs;
    private BoxCollider area;
    float Timer = 0.0f;
    float WaitingTime = 4f;
    bool used = false;

    private List<GameObject> gameObject = new List<GameObject>();

    private Vector3 GetRandomPosition()
    {
     
        Vector3 spawnPos = new Vector3(8.89f, 11.0f, -3.32f);

        return spawnPos;
    }

    private void Spawn()
    {
        int selection = Random.Range(0, prefabs.Length);

        GameObject selectedPrefab = prefabs[selection];

        Vector3 spawnPos = GetRandomPosition();//랜덤위치함수

        GameObject instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        gameObject.Add(instance);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (!used)
            {
                    

                    if (Timer > WaitingTime)
                    {
                    Spawn();
                    used = true;

                    }
                    
            }
        }
    }
    void Update()
    {
        Timer += Time.deltaTime;
    }
}   