using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    Rigidbody2D OurRigidBody;

    float strength;

    bool Attack;

    bool Duck;

    // Start is called before the first frame update
    void Start()
    {

        Attack = false;

        Duck = false;

        OurRigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(0, 0, 0);

        if (Duck == false)
        {

            if (Input.GetKey("w"))
            {

                Vector2 direction = Vector2.up;

                strength = 2;

                OurRigidBody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);

            }

            if (Input.GetKey("s"))
            {

                Vector2 direction = Vector2.down;

                strength = 2;

                OurRigidBody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);

            }

            if (Input.GetKey("a"))
            {

                Vector2 direction = Vector2.left;

                strength = 5;

                OurRigidBody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);

            }

            if (Input.GetKey("d"))
            {

                Vector2 direction = Vector2.right;

                strength = 5;

                OurRigidBody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);

            }

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

                Duck = true;

                StartCoroutine(Wait2());

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

        Duck = false;

    }

}
