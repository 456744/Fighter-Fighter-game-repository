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

    //gets the time taken in secs and mins then displays in text then tells score/time object to destroy self
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
