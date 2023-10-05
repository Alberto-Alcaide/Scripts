using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class WheelMovement : MonoBehaviour
{

    // Definir los parámetros de la rueda y el movimiento
    float radius = 0.5f; // Radio de la rueda en metros
    float omega = 10f; // Velocidad angular de la rueda en radianes por segundo
    float x0 = 0f; // Posición inicial de la rueda en el eje x en metros
    float y0 = 0f; // Posición inicial de la rueda en el eje y en metros
    float tmax = 10f; // Tiempo máximo de simulación en segundos

    float x;
    float y;
    float vx;
    float vy;





    // Mostrar los resultados en la consola


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Crear un bucle para simular el movimiento de la rueda
        if (Input.GetKeyDown("w"))
        {
            // Obtener el tiempo actual en segundos
            float t = Time.time;

            // Comprobar si se ha superado el tiempo máximo de simulación
            if (t <= tmax)
            {
                // Calcular la posición de la rueda en el eje x usando la fórmula x = x0 + omega * radius * t
                x = x0 + omega * radius * t;
                // Calcular la posición de la rueda en el eje y usando la fórmula y = y0 + radius * sin(omega * t)
                y = y0 + radius * Mathf.Sin(omega * t);

                // Calcular la velocidad de la rueda en el eje x usando la fórmula vx = omega * radius
                vx = omega * radius;

                // Calcular la velocidad de la rueda en el eje y usando la fórmula vy = omega * radius * cos(omega * t)
                vy = omega * radius * Mathf.Cos(omega * t);

                // Asignar la posición del objeto usando el método transform.position
                transform.position = new Vector3(x, y, 0);

                // Asignar la rotación del objeto usando el método transform.eulerAngles
                transform.eulerAngles = new Vector3(0, 0, -omega * t * Mathf.Rad2Deg);
            }
        }


    }
}
    
