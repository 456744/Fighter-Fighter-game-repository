using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{

    bool Attack;

    GameObject Hitbox;

    // Start is called before the first frame update
    void Start()
    {

        Attack = false;

        Hitbox = GameObject.Find("Player hitbox");

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

            if (Input.GetKeyDown("i"))
            {

                Attack = true;

                StartCoroutine(Wait2());

            }

            if (Input.GetKeyDown("k"))
            {

                Attack = true;

                StartCoroutine(Wait3());

            }

        }

    }

    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime((float)0.5);

        transform.localPosition = new Vector3(0, 0, 0);

        Attack = false;

    }

    IEnumerator Wait2()
    {

        yield return new WaitForSecondsRealtime(2);

        Hitbox.gameObject.transform.localScale = new Vector2(2, 4);

        yield return new WaitForSecondsRealtime((float)0.5);

        Hitbox.gameObject.transform.localScale = new Vector2((float)0.1, (float)0.75);

        Attack = false;

    }

    IEnumerator Wait3()
    {

        yield return new WaitForSecondsRealtime((float)2.5);

        Attack = false;

    }
}
