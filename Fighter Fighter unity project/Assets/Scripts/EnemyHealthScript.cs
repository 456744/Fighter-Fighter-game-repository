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

    // Start is called before the first frame update
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

        if (Vector2.Distance(Hit.transform.position, gameObject.transform.position) < 1)
        {
            Health--;

            animator.SetBool("Hit", true);
        }

        if(Health <= 0)
        {

            animator.SetBool("Defeat", true);

            SpawnR.GetComponent<EnemySpawnScript>().SpawnR++;

            Score.GetComponent<ScoreScript>().Score = (Score.GetComponent<ScoreScript>().Score + ScoreUp);

            Health = 999999;

            StartCoroutine(Wait());

        }

    }

    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(2);

        Destroy(transform.root.gameObject);

    }
}
