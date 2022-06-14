using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//attempts to flip player sprite to face proper direction but doesn't work as it keeps changing parent object sprite renderer rather than sprite object sprite renderer
public class SpriteFlipScript : MonoBehaviour
{

    SpriteRenderer Sprite;

    // Start is called before the first frame update
    void Start()
    {

        Sprite = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a") || Input.GetKeyDown("j"))
        {
            Sprite.flipX = false;
        }

        if (Input.GetKeyDown("d") || Input.GetKeyDown("l"))
        {
            Sprite.flipX = true;
        }
    }
}
