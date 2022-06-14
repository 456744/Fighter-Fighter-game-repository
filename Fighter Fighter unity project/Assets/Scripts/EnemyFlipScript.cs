using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlipScript : MonoBehaviour
{

    GameObject Player;

    GameObject[] FindPlayer;

    float Direction;

    SpriteRenderer Sprite;

    // Start is used to set starting values
    void Start()
    {

        FindPlayer = GameObject.FindGameObjectsWithTag("Player");

        Player = FindPlayer[0];

        Sprite = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //detects which direction the player is in then makes object face in that direction
        Direction = Player.transform.InverseTransformPoint(transform.position).x;

        if (Direction < 0)
        {
            Sprite.flipX = false;
        }

        if (Direction > 0)
        {
            Sprite.flipX = true;
        }

    }
}
