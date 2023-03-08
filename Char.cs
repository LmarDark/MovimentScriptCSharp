using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char : MonoBehaviour
{
    private float velocidade;
    private Vector2 direcao;

    SpriteRenderer sr;

    public Animator anim;

    void Start()
    {
        velocidade = 5;
        direcao = Vector2.zero;
        sr = GetComponent<SpriteRenderer>();

    }

    void Update()
    {

        transform.Translate(direcao * velocidade * Time.deltaTime);
        direcao = Vector2.zero;

        if (Input.GetKey("w")) {
            direcao += Vector2.up;
        }
        
        if (Input.GetKey("s")) {
            direcao += Vector2.down;
        }
        
        if (Input.GetKey("a")) {
            anim.SetBool("Walk_anim", true);
            direcao += Vector2.left;
            sr.flipX = true;
        }
        
        if (Input.GetKey("d")) {
            direcao += Vector2.right;
            anim.SetBool("Walk_anim", true);
            sr.flipX = false;
        }

        if (Input.GetButtonUp("Horizontal")) {
            anim.SetBool("Walk_anim", false);
            anim.SetBool("Idle_anim", true);
        }

        if (Input.GetButtonUp("Horizontal")) {
            anim.SetBool("Walk_anim", false);
            anim.SetBool("Idle_anim", true);
        }
    }
}



/*
InputPersonagem();
transform.Translate(direcao * velocidade * Time.deltaTime);
*/