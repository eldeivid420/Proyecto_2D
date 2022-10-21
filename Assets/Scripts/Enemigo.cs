using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
    *Detecta la colision del enemigo con el personaje
    *Autor: David Rodriguez
*/
public class Enemigo : MonoBehaviour
{
    public AudioSource efectoMuere;
    public AudioSource efectoEnemigo;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Reproduce un efecto de sonido
            efectoEnemigo.Play();
            //Descontar una vida
            SaludPersonaje.instance.vidas--;
            //Actualizar los corazones
            HUD.instance.ActualizarVidas();
            if(SaludPersonaje.instance.vidas==0)
            {
                //Almacena en preferencias las monedas recolectadas
                PlayerPrefs.SetInt("numeroMonedas", SaludPersonaje.instance.monedas);
                PlayerPrefs.Save(); //Inmediato guarda el valor
                efectoMuere.Play();
                Destroy(other.gameObject, 0.3f);
                //SceneManager.LoadScene("EscenaMenu"); //Pierde y regresa al menu principal
            }
            
        }
    }
}
