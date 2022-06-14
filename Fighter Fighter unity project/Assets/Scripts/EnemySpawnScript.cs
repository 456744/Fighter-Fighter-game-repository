using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{

    public GameObject BEnemy;

    public GameObject SEnemy;

    bool SpawnB;

    int SpawnS;

    public int SpawnR;

    // Start is used to set starting values and spawn first enemy
    void Start()
    {

        SpawnB = false;

        Instantiate(BEnemy);

        SpawnS = 0;

        SpawnR = 0;


    }

    // Update is called once per frame
    void Update()
    {
        //every minute spawn a new basic enemy
        if (SpawnB == false)
        {

            StartCoroutine(Wait());

            SpawnB = true;

        }
        //after 6 mins spawns a stronger enemy
        if(SpawnS >= 6)
        {

            Instantiate(SEnemy);

            SpawnS = 0;

        }
        //used to tell script to spawn new enemy when old one defeated
        if(SpawnR > 0)
        {

            Instantiate(BEnemy);

            SpawnR--;
        }


    }
    //spawns basic enemy
    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(60);

        Instantiate(BEnemy);

        SpawnB = false;

        SpawnS++;

    }
}
