using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerHealth : MonoBehaviour
{
    GameObject HealthObject;

    int HealthVal;

    public Text HealthDisplay;

    //gets the score value from score object then displayes it to text
    void Update()
    {

        HealthObject = GameObject.FindGameObjectsWithTag("PlayerHealth")[0];

        HealthVal = HealthObject.GetComponent<PlayerHealthScript>().Health;

        HealthDisplay = GetComponent<Text>();

        HealthDisplay.text = HealthVal.ToString();

    }
}
