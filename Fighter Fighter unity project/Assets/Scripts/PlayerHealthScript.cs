using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : MonoBehaviour
{

    bool Attack;


    // Start is called before the first frame update
    void Start()
    {

        Attack = false;

    }

    // Update is called once per frame
    void Update()
    {
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
