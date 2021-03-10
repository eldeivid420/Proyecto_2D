using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
    *Permite modificar el parametro velocidad del Animator
    *Para las transiciones
    *Autor: David Rodriguez
*/
public class CambiaAnimacion : MonoBehaviour
{
    private Rigidbody2D rb2D;
    //Animator
    private Animator anim;      //Animator, actualizar parametro velocidad
    //SpriteRenderer, es para cambiar la orientacion. flipX. flipY
    private SpriteRenderer sprRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //Velocidad
        float velocidad = Mathf.Abs(rb2D.velocity.x);
        anim.SetFloat(name:"velocidad", velocidad);

        //Orientacion
        if(rb2D.velocity.x > 0)
        {
            sprRenderer.flipX = false;
        }
        else if (rb2D.velocity.x < 0)
        {
            sprRenderer.flipX = true;
        }
        
        //saltando
        anim.SetBool("saltando", !PruebaPiso.estaEnPiso);
    }
}
