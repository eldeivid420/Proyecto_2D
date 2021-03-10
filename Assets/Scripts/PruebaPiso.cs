using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    *Prueba si el collider esta dentro o fuera de una plataforma
    *Autor: David Rodriguez
*/

public class PruebaPiso : MonoBehaviour
{
   public static bool estaEnPiso = false;

   //Se ejecuta cuando el collider entra a otro collider

   private void OnTriggerEnter2D(Collider2D other)
   {
       if(other.gameObject.tag != "Moneda")
       {
       estaEnPiso = true;
       //print("esta en piso");
       }
   }
   //Se ejecuta cuando el collider sale a otro collider

   private void OnTriggerExit2D(Collider2D other)
   {
       estaEnPiso = false;
       //print("no esta en piso");
   }
}
