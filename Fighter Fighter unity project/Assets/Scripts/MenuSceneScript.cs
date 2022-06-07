using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSceneScript : MonoBehaviour
{
    // When I pressed move to next scene
    void Update()
    {
        if (Input.GetKeyDown("i"))
        {
            SceneManager.LoadScene("Swarm");
        }
    }
}
