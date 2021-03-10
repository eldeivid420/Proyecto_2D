using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    //VARIABLES
    public float maxVelocidadX = 10;  //Movimiento Horizontal
    public float maxVelocidadY = 7;  //Movimiento Vertical

    private Rigidbody2D rigidbody;  //Para fisica

    //METODOS
    
    // Start is called before the first frame update
    void Start()
    {
        //Inicializar variables
        rigidbody = GetComponent<Rigidbody2D>();  //Enlazar RB --> script
    }

    // Update is called once per frame (frecuentemente 60 veces/seg)
    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");  // [-1, 1]
        rigidbody.velocity = new Vector2(movHorizontal*maxVelocidadX, rigidbody.velocity.y);

        //Salto
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical > 0 && PruebaPiso.estaEnPiso)
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, maxVelocidadY);
        }
    }
}
