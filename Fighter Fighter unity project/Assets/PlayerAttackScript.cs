using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
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
            if (Input.GetKeyDown("j"))
            {

                Attack = true;

                transform.localPosition = new Vector3(-1, 0, 0);

                StartCoroutine(Wait());

            }

            if (Input.GetKeyDown("l"))
            {

                Attack = true;

                transform.localPosition = new Vector3(1, 0, 0);

                StartCoroutine(Wait());

            }

        }

    }
    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime((float)0.5);

        transform.localPosition = new Vector3(0, 0, 0);

        Attack = false;

    }
}
