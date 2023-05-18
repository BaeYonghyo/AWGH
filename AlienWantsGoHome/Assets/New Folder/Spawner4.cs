using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner4 : MonoBehaviour
{

    public GameObject[] prefabs;
    private BoxCollider area;
    float Timer = 0.0f;
    float WaitingTime = 2f;
    bool used = false;
    public GameObject enemy;

    private List<GameObject> gameObject = new List<GameObject>();

    private Vector3 GetRandomPosition()
    {
     
        Vector3 spawnPos = new Vector3(-6.36f, 11.1f, 5.625656f);

        return spawnPos;
    }

    private void Spawn()
    {
        int selection = Random.Range(0, prefabs.Length);

        GameObject selectedPrefab = prefabs[selection];

        Vector3 spawnPos = GetRandomPosition();//랜덤위치함수

        GameObject instance = Instantiate(selectedPrefab, spawnPos, Quaternion.identity);
        selectedPrefab.SetActive(true);
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (!used)
            {
                    

                    
                    Spawn();
                    used = true;

             
                    
            }
        }
    }
    void Update()
    {
        Timer += Time.deltaTime;
    }
}   