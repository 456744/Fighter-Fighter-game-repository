using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackScript : MonoBehaviour
{

    GameObject Player;

    GameObject[] FindPlayer;

    bool Side;

    float Direction;

    bool Attack;

    Rigidbody2D RB2D;


    // Start is called before the first frame update
    void Start()
    {

        FindPlayer = GameObject.FindGameObjectsWithTag("Player");

        Player = FindPlayer[0];

        Attack = false;

        RB2D = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        Direction = Player.transform.InverseTransformPoint(transform.position).x;

        //Debug.LogWarning(Direction);

        if (Direction < 0)
        {
            Side = true;
        }

        if (Direction > 0)
        {
            Side = false;
        }

        if (Vector2.Distance(Player.transform.position, gameObject.transform.position) < 3.4 && Attack == false)
        {
            if(Side)
            {

                Attack = true;

                RB2D.MovePosition(RB2D.position + (new Vector2(2, 0)));

                StartCoroutine(Wait());

            }
            else
            {

                Attack = true;

                RB2D.MovePosition(RB2D.position + (new Vector2(-2, 0)));

                StartCoroutine(Wait());

            }


        }
    }

    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime((float)0.5);

        transform.localPosition = new Vector2(0, 0);

        yield return new WaitForSecondsRealtime((float)1.25);

        Attack = false;

    }
}
