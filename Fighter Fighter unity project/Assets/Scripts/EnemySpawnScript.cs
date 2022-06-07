using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{

    public GameObject BEnemy;

    public GameObject SEnemy;

    bool SpawnB;

    int SpawnS;

    // Start is called before the first frame update
    void Start()
    {

        SpawnB = false;

        Instantiate(BEnemy);

        SpawnS = 0;


    }

    // Update is called once per frame
    void Update()
    {

        if (SpawnB == false)
        {

            StartCoroutine(Wait());

            SpawnB = true;

        }

        if(SpawnS >= 6)
        {

            Instantiate(SEnemy);

            SpawnS = 0;

        }


    }

    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(60);

        Instantiate(BEnemy);

        SpawnB = false;

        SpawnS++;

    }
}
