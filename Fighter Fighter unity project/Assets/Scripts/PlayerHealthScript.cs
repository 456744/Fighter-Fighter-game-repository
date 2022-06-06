using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthScript : MonoBehaviour
{

    public int Health;

    GameObject[] FindHit;


    bool Attack;


    // Start is called before the first frame update
    void Start()
    {

        Attack = false;

        Health = 5000;

        FindHit = GameObject.FindGameObjectsWithTag("PlayerHit");

    }

    // Update is called once per frame
    void Update()
    {

        
        Vector3 position = transform.position;

        GameObject closest = null;

        float distance = Mathf.Infinity;

        foreach (GameObject Hit in FindHit)
        {
            Vector3 diff = Hit.transform.position - position;

            float curDistance = diff.sqrMagnitude;

            if (curDistance < distance)
            {
                closest = Hit;

                distance = curDistance;
            }
        }

        if (Vector2.Distance(closest.transform.position, gameObject.transform.position) < 1)
        {
            Debug.LogWarning(Vector2.Distance(closest.transform.position, gameObject.transform.position));

            Health--;
        }

        if (Health == 0)
        {

            Debug.LogWarning("Player scene change");

            SceneManager.LoadScene("Win Screen");
        }

        if (Attack == false)
        {

            if (Input.GetKeyDown("l") || Input.GetKeyDown("j"))
            {

                Attack = true;

                StartCoroutine(Wait());

            }

            if (Input.GetKeyDown("i"))
            {

                Attack = true;

                StartCoroutine(Wait2());

            }

            if (Input.GetKeyDown("k"))
            {

                Attack = true;

                transform.localPosition = new Vector3(0, 100000, 0);

                StartCoroutine(Wait3());

            }
        }
    }

    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime((float)0.5);

        Attack = false;

    }

    IEnumerator Wait2()
    {

        yield return new WaitForSecondsRealtime((float)2.5);

        Attack = false;

    }

    IEnumerator Wait3()
    {



        yield return new WaitForSecondsRealtime((float)2.5);

        transform.localPosition = new Vector3(0, 0, 0);

        Attack = false;

    }
}
