using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*
    *Controla el menu
    *Agregamos los metodos para atender los componentes del menu
    *Autor: David Rodriguez
*/
public class Menu : MonoBehaviour

{
    //Imagen de fondo
    public Image imagenFondo;
    public void Salir()
    {
        
        //Regresa al sistema operativo
        Application.Quit();
    }
   public void IniciarJuego()
   {
       // Cambiar de escena
       //print("Click en boton");

       //Efecto Fade-out
       imagenFondo.canvasRenderer.SetAlpha(0);
       imagenFondo.gameObject.SetActive(true);
       imagenFondo.CrossFadeAlpha(1, 2, true);

       StartCoroutine(CambiarEscena());

       // CAMBIAR escena
       //SceneManager.LoadScene("EscenaMapa");
   }

   private IEnumerator CambiarEscena()
   {
       yield return new WaitForSeconds(2);

       //Ya regreso/tetrmino 
       SceneManager.LoadScene("EscenaMapa");
   }
}
