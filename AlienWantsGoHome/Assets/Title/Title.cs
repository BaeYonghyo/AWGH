using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    void Update()
    {
        //Get space -> start game
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("Main");
        }
    }
}
