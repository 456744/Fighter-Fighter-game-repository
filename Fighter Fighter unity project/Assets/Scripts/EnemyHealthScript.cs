using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealthScript : MonoBehaviour
{

    public int Health;

    GameObject Hit;

    GameObject[] FindHit;

    // Start is called before the first frame update
    void Start()
    {
        Health = 350;

        FindHit = GameObject.FindGameObjectsWithTag("PlayerHit");

        Hit = FindHit[0];
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(Hit.transform.position, gameObject.transform.position) < 1)
        {
            Health--;
        }

        if(Health == 0)
        {

            Debug.LogWarning("scene change");

            SceneManager.LoadScene("Win Screen");
        }

    }
}
