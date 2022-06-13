using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    Rigidbody2D OurRigidBody;

    float strength;

    bool Attack;

    bool Duck;

    private Animator animator;

    SpriteRenderer Sprite;

    // Start is called before the first frame update
    void Start()
    {

        Attack = false;

        Duck = false;

        OurRigidBody = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();

        Sprite = gameObject.GetComponent<SpriteRenderer>();

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

                strength = 3;

                OurRigidBody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);

            }

            if (Input.GetKey("s"))
            {

                Vector2 direction = Vector2.down;

                strength = 3;

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

                animator.SetBool("Punch", true);

                StartCoroutine(Wait());

            }

            if (Input.GetKeyDown("i"))
            {

                Attack = true;

                animator.SetBool("Uppercut", true);

                StartCoroutine(Wait2());

            }

            if (Input.GetKeyDown("k"))
            {

                Attack = true;

                Duck = true;

                animator.SetBool("Duck", true);

                StartCoroutine(Wait2());

            }
        }
    }

    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime((float)0.5);

        Attack = false;

        animator.SetBool("Punch", false);

    }

    IEnumerator Wait2()
    {

        yield return new WaitForSecondsRealtime((float)2.5);

        Attack = false;

        Duck = false;

        animator.SetBool("Uppercut", false);

        animator.SetBool("Duck", false);

    }

}
