using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{

    GameObject Player;

    GameObject[] FindPlayer;

    Rigidbody2D OurRigidBody;

    float strength;

    Vector2 direction;

    bool spawn;

    public Rigidbody2D rb;

    private Animator animator;

    // Start is used to set starting values
    void Start()
    {

        FindPlayer = GameObject.FindGameObjectsWithTag("Player");

        Player = FindPlayer[0];

        strength = 3;

        OurRigidBody = GetComponent<Rigidbody2D>();

        StartCoroutine(Wait());

        spawn = true;

        rb = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //detects if the object is moving
        if (rb.velocity != Vector2.zero)
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
        //prevents the object from rotating
        transform.rotation = Quaternion.Euler(0, 0, 0);
        
        if (spawn == false)
        {
            //walks towards player until in range
            if (Vector2.Distance(Player.transform.position, gameObject.transform.position) > 3.6)
            {

                direction = Player.transform.position - gameObject.transform.position;

                OurRigidBody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);

            }
            //walks away from player until in range
            if (Vector2.Distance(Player.transform.position, gameObject.transform.position) < 3.4)
            {

                direction = -(Player.transform.position - gameObject.transform.position);

                OurRigidBody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);

            }
        }
        //when first spawning walk straight left onto screen
        if (spawn == true)
        {

            direction = Vector2.left;

            OurRigidBody.AddForce(direction.normalized * strength, ForceMode2D.Impulse);

        }

    }
    //waits for object to walk into screen before turning on hitbox
    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime(3);

        GetComponent<BoxCollider2D>().enabled = true;

        spawn = false;

    }
}
