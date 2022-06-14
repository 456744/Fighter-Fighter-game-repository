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

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;

        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Second == false)
        {
            StartCoroutine(Timer());

            Second = true;
        }

        if(TimeS>=60)
        {
            TimeM++;
            TimeS -= 60;
        }

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
