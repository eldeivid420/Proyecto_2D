using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    *Mantiene informacion de la salud del personaje
    *Autor: David Rodriguez
*/

public class SaludPersonaje : MonoBehaviour
{
    public int vidas = 3;

    public int monedas=0;

    public static SaludPersonaje instance;
    
    private void Awake()
    {
        instance = this;
    }
}
