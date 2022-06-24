using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthDisplayScript : MonoBehaviour
{

    SpriteRenderer Sprite;

    Color SpriteColor;

    public float health;

    // Start is called before the first frame update
    void Start()
    {

        Sprite = GetComponent<SpriteRenderer>();
        
        Sprite.color = Color.white;

        SpriteColor = Color.white;

        health = 100;

    }

    // Update is called once per frame
    void Update()
    {

        if(health > 1)
        {
            health /= 100;
        }

        SpriteColor = new Color(1, health, health);

        Sprite.color = SpriteColor;

    }
}
