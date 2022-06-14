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

    private Animator animator;

    // Start is used to set starting values
    void Start()
    {

        FindHit = GameObject.FindGameObjectsWithTag("PlayerHit");

        Hit = FindHit[0];

        SpawnR = (GameObject.FindGameObjectsWithTag("Respawn"))[0];

        Score = (GameObject.FindGameObjectsWithTag("Score"))[0];

        animator = gameObject.GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetBool("Hit", false);
        //detects when object is hit then reduces health
        if (Vector2.Distance(Hit.transform.position, gameObject.transform.position) < 1)
        {
            Health--;

            animator.SetBool("Hit", true);
        }
        //detects when health runs out then starts destroying object
        if(Health <= 0)
        {

            animator.SetBool("Defeat", true);
            //tells the program to spawn a new enemy
            SpawnR.GetComponent<EnemySpawnScript>().SpawnR++;
            //increases the score
            Score.GetComponent<ScoreScript>().Score = (Score.GetComponent<ScoreScript>().Score + ScoreUp);
            //sets the health up to prevent multiple enemies from being spawned
            Health = 999999;

            StartCoroutine(Wait());

        }

    }

    IEnumerator Wait()
    {
        //waits for animation
        yield return new WaitForSecondsRealtime(2);
        //destroyes object
        Destroy(transform.root.gameObject);

    }
}
