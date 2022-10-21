using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* 
 * Reproduce el efecto fade-in en la escena
 * Autor: David Rodriuez
*/


public class FadeIn : MonoBehaviour
{
    //La imagen de fondo
    public Image imagenFondo;
    // Start is called before the first frame update
    void Start()
    {
        imagenFondo.CrossFadeAlpha(0, 2, true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
