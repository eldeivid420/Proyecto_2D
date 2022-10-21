using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 *Controlador del menu pausa (muestra/oculta)
 *Autor: David Rodriguez
*/
public class MenuPausa : MonoBehaviour
{
    private bool estaPausado; //true->en pausa
    public GameObject pantallaPausa; // Panel

    // El usuario solicita pausar/quitar la pausa
    public void Pausar()
    {
        estaPausado = !estaPausado; 
        // Prende/apaga la pantalla
        pantallaPausa.SetActive(estaPausado);
        // Escala de tiempo
        Time.timeScale = estaPausado ? 0 : 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausar();
        }
        
    }
}
