using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//animates when walking
public class SpriteScript : MonoBehaviour
{
    public Rigidbody2D rb;

    private Animator animator;



    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity != Vector2.zero)
        {
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
}
