using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{

    public int Score;

    public int TimeS;

    public int TimeM;

    bool Second = false;

    public bool Delete = false;

    //set score to 0 and prevents object being destroyed during scene transition
    void Start()
    {
        Score = 0;

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //increase timer in seconds
        if (Second == false)
        {
            StartCoroutine(Timer());

            Second = true;
        }
        //when possible removes min from secs then stores
        if(TimeS>=60)
        {
            TimeM++;
            TimeS -= 60;
        }
        //when delete set to true destroy object
        if(Delete)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Timer()
    {

        yield return new WaitForSecondsRealtime(1);

        TimeS++;

        Second = false;

    }
}
