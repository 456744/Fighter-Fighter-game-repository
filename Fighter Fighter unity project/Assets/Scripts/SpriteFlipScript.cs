using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
