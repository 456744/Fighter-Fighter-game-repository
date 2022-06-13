using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{

    public int Score;

    public int Time;

    bool Second = false;

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
    }

    IEnumerator Timer()
    {

        yield return new WaitForSecondsRealtime(1);

        Time++;

        Second = false;

    }
}
