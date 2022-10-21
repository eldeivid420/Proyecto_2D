using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    *Detecta la colision del enemigo con el personaje
    *Autor: David Rodriguez
*/
public class Enemigo : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject, 0.3f);
        }
    }
}
