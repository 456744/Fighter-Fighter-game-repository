using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackScript : MonoBehaviour
{
    //both game object variables are used to get the player object
    GameObject Player;

    GameObject[] FindPlayer;
    //bool value used to tell which side of the object the player is on
    bool Side;
    //used in player position calculation
    float Direction;
    //used to prevent the enemies from constantly attacking
    bool Attack;
    //used to move the object
    Rigidbody2D RB2D;
    //used for animation
    private Animator animator;

    // Start is used to set all initial values
    void Start()
    {
        //gets all object with the player tag then as there should be only one sets the first to player value
        FindPlayer = GameObject.FindGameObjectsWithTag("Player");

        Player = FindPlayer[0];
        //used to prevent object being in constant state of attack
        Attack = false;
        //gets the rigidbody for movement
        RB2D = gameObject.GetComponent<Rigidbody2D>();
        //gets the animator for animation
        animator = gameObject.GetComponentInParent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //calculates direction on x value from object to player object
        Direction = Player.transform.InverseTransformPoint(transform.position).x;
        //stores direction in bool val
        if (Direction < 0)
        {
            Side = true;
        }

        if (Direction > 0)
        {
            Side = false;
        }
        // when in range attacks towards player
        if (Vector2.Distance(Player.transform.position, gameObject.transform.position) < 3.4 && Attack == false)
        {

            animator.SetBool("Punch", true);

            if (Side)
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
    //used to slow down attacks and reset position
    IEnumerator Wait()
    {

        yield return new WaitForSecondsRealtime((float)0.5);

        transform.localPosition = new Vector2(0, 0);

        yield return new WaitForSecondsRealtime((float)1.25);

        Attack = false;

        animator.SetBool("Punch", false);

    }
}
