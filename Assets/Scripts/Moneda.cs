using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    *Detecta la moneda con el personaje
    *Autor: David Rodriguez
*/
public class Moneda : MonoBehaviour
{
    //La moneda colisiono con otro objeto (colliders)
   private void OnTriggerEnter2D(Collider2D other){
       if (other.gameObject.CompareTag("Player"))
       {
           //Recolectar
           //Dejar de dibujar la moneda
           GetComponent<SpriteRenderer>().enabled = false;
           //Prender la explosion
           //moneda.transform.hijo del transform(transform de la explosion).
           gameObject.transform.GetChild(0).gameObject.SetActive(true);
          
           Destroy(gameObject, 0.5f);
       }
   }
}
