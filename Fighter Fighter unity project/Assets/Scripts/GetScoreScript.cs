using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetScoreScript : MonoBehaviour
{
    GameObject ScoreObject;

    int ScoreVal;

    public Text ScoreDisplay;

    //gets the score value from score object then displayes it to text
    void Start()
    {

        ScoreObject = GameObject.FindGameObjectsWithTag("Score")[0];

        ScoreVal = ScoreObject.GetComponent<ScoreScript>().Score;

        ScoreDisplay = GetComponent<Text>();

        ScoreDisplay.text = ScoreVal.ToString();

    }
}
