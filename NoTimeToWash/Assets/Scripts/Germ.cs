using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Germ : MonoBehaviour
{
    Collider2D col;

    public GameObject deathEffect;

    private Plate plate;

    private AudioSource source;

    public int HP;

    void Start()
    {
        source = GetComponent<AudioSource>();
        plate = transform.parent.gameObject.GetComponent<Plate>();
        col = GetComponent<Collider2D>();
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Sponge")
        {
            HP-= 1;
            if(HP == 0){
                plate.germRemoved();
                Destroy(gameObject);
            }
            //Instantiate(deathEffect, transform.position, Quaternion.identity);
            //gm.GameOver();
            //Colocar pontos para vencer
        }
    }

}

