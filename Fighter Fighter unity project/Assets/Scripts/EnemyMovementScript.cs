using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{

    GameObject Player;

    GameObject[] FindPlayer;

    Rigidbody2D OurRigidBody;

    float strength;

    // Start is called before the first frame update
    void Start()
    {

        FindPlayer = GameObject.FindGameObjectsWithTag("Player");

        Player = FindPlayer[0];

        strength = 3;

        OurRigidBody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        transform.rotation = Quaternion.Euler(0, 0, 0);

        if (Vector2.Distance(Player.transform.position, gameObject.transform.position) > 3.6)
        {

            Vector2 direction = Player.transform.position - gameObject.transform.position ;

            OurRigidBody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);

        }

        if (Vector2.Distance(Player.transform.position, gameObject.transform.position) < 3.4)
        {

            Vector2 direction = -(Player.transform.position - gameObject.transform.position);

            OurRigidBody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);

        }


    }
}
