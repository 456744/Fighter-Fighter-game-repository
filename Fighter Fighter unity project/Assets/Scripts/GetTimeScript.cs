using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetTimeScript : MonoBehaviour
{
    GameObject ScoreObject;

    int TimeSVal;

    int TimeMVal;

    public Text ScoreDisplay;

    // Start is called before the first frame update
    void Start()
    {

        ScoreObject = GameObject.FindGameObjectsWithTag("Score")[0];

        TimeSVal = ScoreObject.GetComponent<ScoreScript>().TimeS;

        TimeMVal = ScoreObject.GetComponent<ScoreScript>().TimeM;

        ScoreDisplay = GetComponent<Text>();

        ScoreDisplay.text = TimeMVal.ToString() + ":" + TimeSVal.ToString();

        ScoreObject.GetComponent<ScoreScript>().Delete = true;

    }
}
