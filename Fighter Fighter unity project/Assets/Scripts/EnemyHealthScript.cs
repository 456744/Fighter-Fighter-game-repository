using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealthScript : MonoBehaviour
{

    public int Health;

    GameObject Hit;

    GameObject[] FindHit;

    public GameObject SpawnR;

    public GameObject Score;

    public int ScoreUp;

    // Start is called before the first frame update
    void Start()
    {

        FindHit = GameObject.FindGameObjectsWithTag("PlayerHit");

        Hit = FindHit[0];

        SpawnR = (GameObject.FindGameObjectsWithTag("Respawn"))[0];

        Score = (GameObject.FindGameObjectsWithTag("Score"))[0];
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(Hit.transform.position, gameObject.transform.position) < 1)
        {
            Health--;
        }

        if(Health <= 0)
        {

            SpawnR.GetComponent<EnemySpawnScript>().SpawnR++;

            Score.GetComponent<ScoreScript>().Score = (Score.GetComponent<ScoreScript>().Score + ScoreUp);

            Destroy(transform.root.gameObject);

        }

    }
}
