using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour
{

    public int Health;

    // Start is called before the first frame update
    void Start()
    {
        Health = 10;
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider collision)
    {

        if (CompareTag("PlayerHit"))
        {
            Health--;
        }

        if(Health == 0)
        {
            Debug.LogWarning("Defeat");
        }

    }
}
