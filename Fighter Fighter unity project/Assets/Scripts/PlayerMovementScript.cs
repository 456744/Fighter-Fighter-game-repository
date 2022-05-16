using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    Rigidbody2D OurRigidBody;

    float strength;

    private void Start()
    {
        OurRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(0, 0, 0);

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

}
