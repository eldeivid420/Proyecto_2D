using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
    *Controla el menu
    *Agregamos los metodos para atender los componentes del menu
    *Autor: David Rodriguez
*/
public class Menu : MonoBehaviour
{
    public void Salir()
    {
        //Regresa al sistema operativo
        Application.Quit();
    }
   public void IniciarJuego()
   {
       // Cambiar de escena
       //print("Click en boton");

       // CAMBIAR escena
       SceneManager.LoadScene("EscenaMapa");
   }
}
