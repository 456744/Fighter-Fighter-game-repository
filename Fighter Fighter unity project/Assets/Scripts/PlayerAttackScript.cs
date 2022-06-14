using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{

    bool Attack;

    GameObject Hitbox;

    Rigidbody2D RB2D;

    // Start is called before the first frame update
    void Start()
    {

        Attack = false;

        Hitbox = GameObject.Find("Player hitbox");

        RB2D = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Attack == false)
        {
            //when j pressed punch to left
            if (Input.GetKeyDown("j"))
            {

                Attack = true;

                RB2D.MovePosition(RB2D.position + (new Vector2(-2, 0)));

                StartCoroutine(Wait());

            }
            //when l pressed punch to right
            if (Input.GetKeyDown("l"))
            {

                Attack = true;

                RB2D.MovePosition(RB2D.position + (new Vector2(2, 0)));

                StartCoroutine(Wait());

            }
            //when i pressed uppercut
            if (Input.GetKeyDown("i"))
            {

                Attack = true;

                StartCoroutine(Wait2());

            }
            //when k pressed duck
            if (Input.GetKeyDown("k"))
            {

                Attack = true;

                StartCoroutine(Wait3());

            }

        }

    }
    //wait for various times and reset positions
    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime((float)0.5);

        transform.localPosition = new Vector2(0, 0);

        Attack = false;

    }

    IEnumerator Wait2()
    {

        yield return new WaitForSecondsRealtime(2);

        Hitbox.gameObject.transform.localScale = new Vector2(2, 4);

        yield return new WaitForSecondsRealtime((float)0.5);

        Hitbox.gameObject.transform.localScale = new Vector2((float)0.2, (float)3);

        Attack = false;

    }

    IEnumerator Wait3()
    {

        yield return new WaitForSecondsRealtime((float)2.5);

        Attack = false;

    }
}
