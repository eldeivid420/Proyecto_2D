using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    *Detecta la moneda con el personaje
    *Autor: David Rodriguez
*/
public class Moneda : MonoBehaviour
{
    //La referencia al Audio Source
    public AudioSource efectoMoneda;

    //La referencia al sistema de particulas
    public ParticleSystem hit;
    //La moneda colisiono con otro objeto (colliders)
   private void OnTriggerEnter2D(Collider2D other){
       if (other.gameObject.CompareTag("Player"))
       {
           //Mostrar la explosion con el sistema de particulas
           hit.Play();
           
           //Recolectar
           //Reproducir un efecto de sonido
           efectoMoneda.Play();
           //Dejar de dibujar la moneda
           GetComponent<SpriteRenderer>().enabled = false;
           //Prender la explosion
           //moneda.transform.hijo del transform(transform de la explosion).
           gameObject.transform.GetChild(0).gameObject.SetActive(true);
          
           Destroy(gameObject, 0.5f);

           //Contar monedas
           SaludPersonaje.instance.monedas += 25;
           HUD.instance.ActualizarMonedas();
       }
   }
}
